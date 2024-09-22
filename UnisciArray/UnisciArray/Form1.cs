namespace UnisciArray
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int[] vettore_1;
        int[] vettore_2;
        int[] vettore_unione;
        private void button2_Click(object sender, EventArgs e)
        {
            vettore_1 = crea_vettore(arrayText1.Text);
            vettore_2 = crea_vettore(arrayText2.Text);

            intersezione(vettore_1, vettore_2, out vettore_unione);


            arrayUnione.Text = convertToString(vettore_unione);
        }

        private int[] crea_vettore(string s)
        {
            int count = 1;
            for (int i = 0; i < s.Length; i++)
                if (s[i].Equals(','))
                    count++;

            int[] array = new int[count];
            string num = "";

            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if (s[i] != ',')
                {
                    num += s[i];
                }
                else
                {
                    array[j] = int.Parse(num);
                    num = "";
                    j++;
                }
            }

            array[count - 1] = int.Parse(num);
            return array;
        }

        private void intersezione(int[] v1, int[] v2, out int[] v_intersezione)
        {
            int count = 0;
            for (int i = 0; i < v1.Length; i++)
                if (checkPervenuto(v2, v1[i]))
                    count++;

            v_intersezione = new int[count];

            for (int i = 0, j = 0; i < v1.Length; i++)
                if (checkPervenuto(v2, v1[i]))
                {
                    v_intersezione[j] = v1[i];
                    j++;
                }
        }

        private bool checkPervenuto(int[] vet, int n)
        {
            for (int i = 0; i < vet.Length; i++)
                if (vet[i] == n)
                    return true;

            return false;
        }

        private string convertToString(int[] arr)
        {
            string s = "";
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
                if (i < arr.Length - 1)
                    s += ',';
            }

            return s;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int[] vettore_1 = {};
            int[] vettore_2 = {};
            int[] vettore_unione = {};

            arrayText1.Clear();
            arrayText2.Clear();
            arrayUnione.Clear();
        }
    }
}
