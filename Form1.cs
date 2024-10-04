namespace Nguyenvantan_buoi9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.printOut("lụm");
            IIfc1 ifc = (IIfc1)mc;
            ifc.printOut("lụm luôn");
        }
    }
}
