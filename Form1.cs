using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class frm1_converter : Form
    {
        public frm1_converter()
        {
            InitializeComponent();
        }

        private String DgvToString(DataGridViewRowCollection rows)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Idx\tRaw\tOutput\n");
            foreach (DataGridViewRow row in rows)
            {
                var s = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    s.Add(cell.Value.ToString());
                }
                sb.Append(string.Join("\t", s) + "\n");
            }
            return sb.ToString();
        }

        private String FormatHex(string hexstring)
        {
            return string.Join(" ", ChunksUpto(hexstring.ToUpper(), 2).ToList());
        }

        private String Reverse(string hexString)
        {
            List<string> chunks = ChunksUpto(hexString, 2).ToList();
            chunks.Reverse();
            return string.Join("", chunks);
        }

        private void ToASCII(List<string> hexStrings)
        {
            var source = new BindingSource();
            List<MyStruct> output = new List<MyStruct>();
            hexStrings.ForEach(i => Console.Write("{0}\t", i));
            for(int i = 0; i < hexStrings.Count; i++)
            {
                var hexString = hexStrings[i];
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < hexString.Length; j += 2)
                {
                    string hs = (j + 2 < hexString.Length) ? hexString.Substring(j, 2) 
                        : new string('0', hexString.Length - j - 1) + hexString.Substring(j, hexString.Length - j);
                    sb.Append(Convert.ToChar(Convert.ToUInt32(hs, 16)));
                }
                output.Add( new MyStruct(i, FormatHex(hexString.PadLeft(4, '0')), sb.ToString()) );
            }
            source.DataSource = output;
            dgv_ascii.DataSource = source;
            dgv_ascii.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ToFloat(List<string> hexStrings)
        {
            var source = new BindingSource();
            List<MyStruct> output = new List<MyStruct>();

            for (int i = 0; i < hexStrings.Count; i++)
            {
                var hexString = hexStrings[i];
                uint num = uint.Parse(hexString, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals = BitConverter.GetBytes(num);
                float f = BitConverter.ToSingle(floatVals, 0);
                output.Add(new MyStruct(i, FormatHex(hexString.PadLeft(8, '0')), f.ToString()));
            }
            source.DataSource = output;
            dgv_float.DataSource = source;
            dgv_float.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ToUint16(List<string> hexStrings)
        {
            var source = new BindingSource();
            List<MyStruct> output = new List<MyStruct>();

            for (int i = 0; i < hexStrings.Count; i++)
            {
                var hexString = hexStrings[i];
                var f = Convert.ToUInt16(hexString, 16);
                output.Add(new MyStruct(i, FormatHex(hexString.PadLeft(4, '0')), f.ToString()));
            }
            source.DataSource = output;
            dgv_uint16.DataSource = source;
            dgv_uint16.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ToUint32(List<string> hexStrings)
        {
            var source = new BindingSource();
            List<MyStruct> output = new List<MyStruct>();

            for (int i = 0; i < hexStrings.Count; i++)
            {
                var hexString = hexStrings[i];
                var f = Convert.ToUInt32(hexString, 16);
                output.Add(new MyStruct(i, FormatHex(hexString.PadLeft(8, '0')), f.ToString()));
            }
            source.DataSource = output;
            dgv_uint32.DataSource = source;
            dgv_uint32.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ToUint64(List<string> hexStrings)
        {
            var source = new BindingSource();
            List<MyStruct> output = new List<MyStruct>();

            for (int i = 0; i < hexStrings.Count; i++)
            {
                var hexString = hexStrings[i];
                var f = Convert.ToUInt64(hexString, 16);
                output.Add(new MyStruct(i, FormatHex(hexString.PadLeft(16, '0')), f.ToString()));
            }
            source.DataSource = output;
            dgv_uint64.DataSource = source;
            dgv_uint64.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        static IEnumerable<string> ChunksUpto(string str, int maxChunkSize) {
            for (int i = 0; i < str.Length; i += maxChunkSize)
            {
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
            }
        }

        private string FloatToHex(string input)
        {
            var val = float.Parse(input);
            byte[] b = BitConverter.GetBytes(val);
            StringBuilder sb = new StringBuilder();

            foreach (byte by in b)
                sb.Append(by.ToString("X2"));
            return sb.ToString();
        }

        #region btnEvents
        private void btn_do_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtbox_input.Text, @"^[A-f0-9\s\n\t\r]+$"))
            {
                MessageBox.Show("invalid input, allowed A-f0-9 and space");
                return;
            }
            var text = Regex.Replace(txtbox_input.Text, @"[\s\t\r\n]+", "");
            text = text.PadRight(4, '0');
            var twobyte = ChunksUpto(Reverse(text), 4).ToList();
            var fourbyte = ChunksUpto(Reverse(text), 8).ToList();
            var eightbyte = ChunksUpto(Reverse(text), 16).ToList();
            ToASCII(twobyte);
            ToFloat(fourbyte);
            ToUint16(twobyte);
            ToUint32(fourbyte);
            ToUint64(eightbyte);
            txtbox_input.Text = FormatHex(text);
        }

        private void btn_do_dec_Click(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txtbox_dec_input.Text, @"^[0-9\.n]"))
            {
                MessageBox.Show("invalid input, allowed 0-9 and .");
                return;
            }
            var text = txtbox_dec_input.Text.Replace("n", "");
            string value = "";
            if (text.Contains("."))
            {
                value = FloatToHex(text);
            } else
            {
                long decValue = 0;
                if(!long.TryParse(text, out decValue))
                {
                    MessageBox.Show("Couldnt convert input to long");
                    return;
                }
                value = decValue.ToString("X");
            }
            txt_big.Text = FormatHex(Reverse(value));
            txt_little.Text = FormatHex(value);
        }
        #endregion

        #region dgvCellDClickEvents
        private void dgv_ascii_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(dgv_ascii.CurrentCell.Value.ToString());
        }

        private void dgv_float_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(dgv_float.CurrentCell.Value.ToString());
        }

        private void dgv_uint16_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(dgv_uint16.CurrentCell.Value.ToString());
        }

        private void dgv_uint32_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(dgv_uint32.CurrentCell.Value.ToString());
        }

        private void dgv_uint64_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(dgv_uint64.CurrentCell.Value.ToString());
        }

        private void lb_ascii_DoubleClick(object sender, EventArgs e)
        {
            
            Clipboard.SetText(DgvToString(dgv_ascii.Rows));
        }

        private void lb_float_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(DgvToString(dgv_float.Rows));
        }

        private void lb_uint16_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(DgvToString(dgv_uint16.Rows));
        }

        private void lb_uint32_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(DgvToString(dgv_uint32.Rows));
        }

        private void lb_uint64_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(DgvToString(dgv_uint64.Rows));
        }
        #endregion
    }

}
class MyStruct
{
    public int Idx { get; set; }
    public string Raw { get; set; }
    public string Output { get; set; }

    public MyStruct(int idx, string raw, string output)
    {
        Idx = idx;
        Raw = raw;
        Output = output;
    }

    public override string ToString()
    {
        return String.Format("{0}\t{1}\t{2}", Idx, Raw, Output);
    }
}
