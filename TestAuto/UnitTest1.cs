using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace TestAuto
{
    [TestClass]
    public class TestPrimaApp 
    {
        /// <summary>
        /// Tests Auto Accendi
        /// </summary>
        [TestMethod]
        public void TestTurnWithoutFuel()
        {

            prima_app.Auto miaAuto2 = new prima_app.Auto("", "", "", prima_app.Auto.motore.elettrico,0,0);
          
            miaAuto2 = new prima_app.Auto();

            miaAuto2.accendi();
            if (miaAuto2.GeneraStato() == "carburante: 0spenta")
            {

            } else{
                throw new Exception("");
            }
            

        }

        [TestMethod]
        public void TestTurnOn()
        {

            prima_app.Auto miaAuto2; 

            miaAuto2 = new prima_app.Auto();

            miaAuto2.accendi();
            if (miaAuto2.GeneraStato() == "carburante: 50accesa")
            //if (miaAuto2.GeneraStato() == "carburante: 50spenta")
                {

            }
            else
            {
                throw new Exception("");
            }
            

        }
    }
}