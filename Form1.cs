namespace CSharp_GiaTienDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            txtTong.Clear();
            double SD, ST, GT, SL;
            ST = 0;
            SL = 0;
            SD = Convert.ToInt32(txtSD.Text);
            do
            {
                GT = 1806;
                ST += GT;
                SD--;
                SL++;
            } while (SD > 0 & SL < 50);
            SL = 0;
            do
            {
                if (SD > 0)
                {
                    GT = 1866;
                    ST += GT;
                    SD--;
                    SL++;
                }
            } while (SD > 0 & SL < 50);
            SL = 0;
            do
            {
                if (SD > 0)
                {
                    GT = 2167;
                    ST += GT;
                    SD--;
                    SL++;
                }
            } while (SD > 0 & SL < 50);
            SL = 0;
            do
            {
                if (SD > 0)
                {
                    GT = 2729;
                    ST += GT;
                    SD--;
                    SL++;
                }
            } while (SD > 0 & SL < 50);
            SL = 0;
            do
            {
                if (SD > 0)
                {
                    GT = 3050;
                    ST += GT;
                    SD--;
                    SL++;
                }
            } while (SD > 0 & SL < 50);
            do
            {
                if (SD > 0)
                {
                    GT = 3151;
                    ST += GT;
                    SD--;
                }
            } while (SD > 0);
            txtTong.Text = ST.ToString() + "đ";
        }
    }
}
