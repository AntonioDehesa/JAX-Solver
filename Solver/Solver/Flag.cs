using System;
using System.IO;

namespace Solver
{
    internal class Flag
    {
        private string s;

        public Flag(string _f)
        {
            try
            {
                File.ReadAllText(_f.ToCharArray()[8].ToString());
                this.s = "hackdf{NOP_ESTO_NO_ES_LO_QUE_BUSCAS!}";
            }
            catch (Exception ex)
            {
                this.l(ex, _f);
            }
        }

        private void l(Exception e, string _f)
        {
            string message = e.Message;
            //Console.WriteLine("Message: {0}", message.ToCharArray());
            this.s = "";
            Console.WriteLine(this.s);
            if (e.GetType() == typeof(IndexOutOfRangeException))
            {
                string str = this.f(_f);
                long num = 137438953472;//39
                int[] numArray = new int[32]
                {
          -47,
          -86,
          -107,
          -101,
          -83,
          -41,
          -80,
          -82,
          13,
          9,
          -22,
          -82,
          -68,
          -81,
          -91,
          -49,
          -80,
          -80,
          -71,
          -87,
          -30,
          0,
          -36,
          -97,
          -12,
          -61,
          -101,
          -67,
          -94,
          -75,
          -26,
          -15
                };
                char[] charArray1 = message.ToCharArray();
                char[] charArray2 = str.ToCharArray();
                //Console.WriteLine("bb: {0}", ((long)this.s.Length & num) == 0L); 
                for (; ((long)this.s.Length & num) == 0L; num >>= 1)
                {
                    this.s += Convert.ToChar((byte)((uint)Convert.ToByte(charArray1[this.s.Length])
                        ^ (uint)(byte)((uint)Convert.ToByte(charArray2[this.s.Length % 8])
                        + (uint)numArray[this.s.Length]))).ToString();
                    //Console.WriteLine(this.s.Length % 8);
                }
            }
            else
                Console.WriteLine("Nop, esa no es la excepcion correcta");
        }

        public string print() => this.s;

        private string f(string inp) => (inp.Length & 8) <= 0 ? this.f(inp + "x") : inp;//Esta funcion siempre lo acompleta a 8 length
    }
}
