using System;
using System.Windows.Forms;

namespace SaludoFormG2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SaludoForm saludoForm = new SaludoForm();
            Application.Run(new SaludoForm() );//como no se require un ID, se le conoce como obj. anonimo
        }
    }
}
