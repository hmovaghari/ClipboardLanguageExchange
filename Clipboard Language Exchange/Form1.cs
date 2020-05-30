using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Clipboard_Language_Exchange
{
    public partial class Form1 : Form
    {

        public string inpute = "";
        
        public Form1(string[] args)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;
            TransparencyKey = Color.Black;
            try
            {
                inpute = args[0];
            }
            catch
            {
                inpute = "";
            }
            
        }

        public override sealed Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (inpute == "1")
            {
                notifyIcon1.Visible = false;
                clipboardToEnglishPersianToolStripMenuItem_Click(sender, e);
                Application.Exit();
            }
        }

        private void Form1_Exit(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Exit(sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 helpForm = new Form2();
            helpForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"قدرت گرفته آفتابگردان، بهینه شده توسط حامد موقری" + Environment.NewLine + @"سایت : http://aftab.cc" +
                Environment.NewLine + @"سایت : http://hmovaghari.rozblog.com", @"", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void clipboardToEnglishPersianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Clipboard.ContainsText()))
                MessageBox.Show(@"لطفا ابتدا یک متن کپی کنید", @"", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            else
            {
                string str = Clipboard.GetText();
                string str_new = "";
                char[] alphabet = new char[]
                {
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                    'u',
                    'w', 'x', 'y', 'z', ' '
                };
                for (int i = 0; i < str.Length; i++)
                {



                    switch (Convert.ToChar(str.Substring(i, 1)))
                    {
                        //Common Characters
                        case ' ':
                            str_new = str_new + Convert.ToString(' ');
                            break;
                        case ':':
                            str_new = str_new + Convert.ToString(':');
                            break;
                        case '"':
                            str_new = str_new + Convert.ToString('"');
                            break;
                        case '?':
                            str_new = str_new + Convert.ToString('؟');
                            break;
                        case '؟':
                            str_new = str_new + Convert.ToString('?');
                            break;

                        //Farsi to English
                        case 'ض':
                            str_new = str_new + Convert.ToString('q');
                            break;
                        case 'ص':
                            str_new = str_new + Convert.ToString('w');
                            break;
                        case 'ث':
                            str_new = str_new + Convert.ToString('e');
                            break;
                        case 'ق':
                            str_new = str_new + Convert.ToString('r');
                            break;
                        case 'ف':
                            str_new = str_new + Convert.ToString('t');
                            break;
                        case 'غ':
                            str_new = str_new + Convert.ToString('y');
                            break;
                        case 'ع':
                            str_new = str_new + Convert.ToString('u');
                            break;
                        case 'ه':
                            str_new = str_new + Convert.ToString('i');
                            break;
                        case 'خ':
                            str_new = str_new + Convert.ToString('o');
                            break;
                        case 'ح':
                            str_new = str_new + Convert.ToString('p');
                            break;
                        case 'ج':
                            str_new = str_new + Convert.ToString('[');
                            break;
                        case 'چ':
                            str_new = str_new + Convert.ToString(']');
                            break;
                        case 'ش':
                            str_new = str_new + Convert.ToString('a');
                            break;
                        case 'س':
                            str_new = str_new + Convert.ToString('s');
                            break;
                        case 'ی':
                            str_new = str_new + Convert.ToString('d');
                            break;
                        case 'ب':
                            str_new = str_new + Convert.ToString('f');
                            break;
                        case 'ل':
                            str_new = str_new + Convert.ToString('g');
                            break;
                        case 'ا':
                            str_new = str_new + Convert.ToString('h');
                            break;
                        case 'ت':
                            str_new = str_new + Convert.ToString('j');
                            break;
                        case 'ن':
                            str_new = str_new + Convert.ToString('k');
                            break;
                        case 'م':
                            str_new = str_new + Convert.ToString('l');
                            break;
                        case 'ک':
                            str_new = str_new + Convert.ToString(';');
                            break;
                        case 'گ':
                            str_new = str_new + Convert.ToString('\'');
                            break;
                        case 'ظ':
                            str_new = str_new + Convert.ToString('z');
                            break;
                        case 'ط':
                            str_new = str_new + Convert.ToString('x');
                            break;
                        case 'ز':
                            str_new = str_new + Convert.ToString('c');
                            break;
                        case 'ر':
                            str_new = str_new + Convert.ToString('v');
                            break;
                        case 'ذ':
                            str_new = str_new + Convert.ToString('b');
                            break;
                        case 'د':
                            str_new = str_new + Convert.ToString('n');
                            break;
                        case 'ئ':
                            str_new = str_new + Convert.ToString('m');
                            break;
                        case 'و':
                            str_new = str_new + Convert.ToString(',');
                            break;
                        case '.':
                            str_new = str_new + Convert.ToString('.');
                            break;
                        case 'ً':
                            str_new = str_new + Convert.ToString('Q');
                            break;
                        case 'ٌ':
                            str_new = str_new + Convert.ToString('W');
                            break;
                        case 'ٍ':
                            str_new = str_new + Convert.ToString('E');
                            break;
                        case '،':
                            str_new = str_new + Convert.ToString('T');
                            break;
                        case '؛':
                            str_new = str_new + Convert.ToString('Y');
                            break;
                        case '٫':
                            str_new = str_new + Convert.ToString('U');
                            break;
                        case 'ة':
                            str_new = str_new + Convert.ToString('I');
                            break;
                        case ']':
                            int t1 = 0;
                            foreach (char c in alphabet)
                            {
                                if (i + 1 < str.Length)
                                {
                                    if (c == Convert.ToChar(str.Substring(i + 1, 1)))
                                    {
                                        t1 = 1;
                                        break;
                                    }
                                }
                            }
                            if (t1 == 1)
                                str_new = str_new + Convert.ToString('چ');
                            else
                                str_new = str_new + Convert.ToString('O');
                            break;
                        case '[':
                            int t2 = 0;
                            foreach (char c in alphabet)
                            {
                                if (i + 1 < str.Length)
                                {
                                    if (c == Convert.ToChar(str.Substring(i + 1, 1)))
                                    {
                                        t2 = 1;
                                        break;
                                    }
                                }
                            }
                            if (t2 == 1)
                                str_new = str_new + Convert.ToString('ج');
                            else
                                str_new = str_new + Convert.ToString('P');
                            break;
                        case '}':
                            str_new = str_new + Convert.ToString('{');
                            break;
                        case '{':
                            str_new = str_new + Convert.ToString('}');
                            break;
                        case 'َ':
                            str_new = str_new + Convert.ToString('A');
                            break;
                        case 'ُ':
                            str_new = str_new + Convert.ToString('S');
                            break;
                        case 'ِ':
                            str_new = str_new + Convert.ToString('D');
                            break;
                        case 'ّ':
                            str_new = str_new + Convert.ToString('F');
                            break;
                        case 'ۀ':
                            str_new = str_new + Convert.ToString('G');
                            break;
                        case 'آ':
                            str_new = str_new + Convert.ToString('H');
                            break;
                        case 'ـ':
                            str_new = str_new + Convert.ToString('J');
                            break;
                        case '»':
                            str_new = str_new + Convert.ToString('K');
                            break;
                        case '«':
                            str_new = str_new + Convert.ToString('L');
                            break;
                        case 'ؤ':
                            str_new = str_new + Convert.ToString('Z');
                            break;
                        case '‍':
                            str_new = str_new + Convert.ToString('X');
                            break;
                        case 'ي':
                            str_new = str_new + Convert.ToString('V');
                            break;
                        case 'إ':
                            str_new = str_new + Convert.ToString('B');
                            break;
                        case 'أ':
                            str_new = str_new + Convert.ToString('N');
                            break;
                        case 'ء':
                            str_new = str_new + Convert.ToString('M');
                            break;
                        case '>':
                            str_new = str_new + Convert.ToString('<');
                            break;
                        case '<':
                            str_new = str_new + Convert.ToString('>');
                            break;
                        case 'پ':
                            str_new = str_new + Convert.ToString('`');
                            break;
                        case 'ژ':
                            str_new = str_new + Convert.ToString('\\');
                            break;

                        //English to Farsi

                        case 'q':
                            str_new = str_new + Convert.ToString('ض');
                            break;
                        case 'w':
                            str_new = str_new + Convert.ToString('ص');
                            break;
                        case 'e':
                            str_new = str_new + Convert.ToString('ث');
                            break;
                        case 'r':
                            str_new = str_new + Convert.ToString('ق');
                            break;
                        case 't':
                            str_new = str_new + Convert.ToString('ف');
                            break;
                        case 'y':
                            str_new = str_new + Convert.ToString('غ');
                            break;
                        case 'u':
                            str_new = str_new + Convert.ToString('ع');
                            break;
                        case 'i':
                            str_new = str_new + Convert.ToString('ه');
                            break;
                        case 'o':
                            str_new = str_new + Convert.ToString('خ');
                            break;
                        case 'p':
                            str_new = str_new + Convert.ToString('ح');
                            break;
                        case 'a':
                            str_new = str_new + Convert.ToString('ش');
                            break;
                        case 's':
                            str_new = str_new + Convert.ToString('س');
                            break;
                        case 'd':
                            str_new = str_new + Convert.ToString('ی');
                            break;
                        case 'f':
                            str_new = str_new + Convert.ToString('ب');
                            break;
                        case 'g':
                            str_new = str_new + Convert.ToString('ل');
                            break;
                        case 'h':
                            str_new = str_new + Convert.ToString('ا');
                            break;
                        case 'j':
                            str_new = str_new + Convert.ToString('ت');
                            break;
                        case 'k':
                            str_new = str_new + Convert.ToString('ن');
                            break;
                        case 'l':
                            str_new = str_new + Convert.ToString('م');
                            break;
                        case ';':
                            str_new = str_new + Convert.ToString('ک');
                            break;
                        case '\'':
                            str_new = str_new + Convert.ToString('گ');
                            break;
                        case 'z':
                            str_new = str_new + Convert.ToString('ظ');
                            break;
                        case 'x':
                            str_new = str_new + Convert.ToString('ط');
                            break;
                        case 'c':
                            str_new = str_new + Convert.ToString('ز');
                            break;
                        case 'v':
                            str_new = str_new + Convert.ToString('ر');
                            break;
                        case 'b':
                            str_new = str_new + Convert.ToString('ذ');
                            break;
                        case 'n':
                            str_new = str_new + Convert.ToString('د');
                            break;
                        case 'm':
                            str_new = str_new + Convert.ToString('ئ');
                            break;
                        case ',':
                            str_new = str_new + Convert.ToString('و');
                            break;
                        case 'Q':
                            str_new = str_new + Convert.ToString('ً');
                            break;
                        case 'W':
                            str_new = str_new + Convert.ToString('ٌ');
                            break;
                        case 'E':
                            str_new = str_new + Convert.ToString('ٍ');
                            break;
                        case 'R':
                            str_new = str_new + "ريال";
                            break;
                        case 'T':
                            str_new = str_new + Convert.ToString('،');
                            break;
                        case 'Y':
                            str_new = str_new + Convert.ToString('؛');
                            break;
                        case 'A':
                            str_new = str_new + Convert.ToString('َ');
                            break;
                        case 'S':
                            str_new = str_new + Convert.ToString('ُ');
                            break;
                        case 'D':
                            str_new = str_new + Convert.ToString('ِ');
                            break;
                        case 'M':
                            str_new = str_new + Convert.ToString('ء');
                            break;
                        case 'F':
                            str_new = str_new + Convert.ToString('ّ');
                            break;
                        case 'H':
                            str_new = str_new + Convert.ToString('آ');
                            break;
                        case 'J':
                            str_new = str_new + Convert.ToString('ـ');
                            break;
                        case 'K':
                            str_new = str_new + Convert.ToString('»');
                            break;
                        case 'L':
                            str_new = str_new + Convert.ToString('«');
                            break;
                        case 'Z':
                            str_new = str_new + Convert.ToString('ؤ');
                            break;
                        case 'C':
                            str_new = str_new + Convert.ToString('ژ');
                            break;
                        case '\\':
                            str_new = str_new + Convert.ToString('ژ');
                            break;
                        case 'B':
                            str_new = str_new + Convert.ToString('إ');
                            break;
                        case 'N':
                            str_new = str_new + Convert.ToString('أ');
                            break;
                        case '`':
                            str_new = str_new + Convert.ToString('پ');
                            break;


                        default:
                            str_new = str_new + Convert.ToChar(str.Substring(i, 1));
                            break;
                    }

                }
                str_new = str_new.Replace("vVhg", "R");
                Clipboard.SetText(str_new);
            }
        }
    }
}
