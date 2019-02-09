using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedConcepts.Classes
{
    class InputTextBox2:TextBox
    {
        private List<int> _codeList = new List<int>();

        private const int SPACE_CHAR = 32;
        private const int BACK_SPACE = 8;




        public InputTextBox2()
        {
            _codeList.Add(65);
            _codeList.Add(66);
            _codeList.Add(67);
            _codeList.Add(68);
            _codeList.Add(69);
            _codeList.Add(70);
            _codeList.Add(71);
            _codeList.Add(72);
            _codeList.Add(73);
            _codeList.Add(74);
            _codeList.Add(75);
            _codeList.Add(76);
            _codeList.Add(77);
            _codeList.Add(78);
            _codeList.Add(79);
            _codeList.Add(80);
            _codeList.Add(81);
            _codeList.Add(82);
            _codeList.Add(83);
            _codeList.Add(84);
            _codeList.Add(85);
            _codeList.Add(86);
            _codeList.Add(87);
            _codeList.Add(88);
            _codeList.Add(89);
            _codeList.Add(90);
            _codeList.Add(97);
            _codeList.Add(98);
            _codeList.Add(99);
            _codeList.Add(100);
            _codeList.Add(101);
            _codeList.Add(102);
            _codeList.Add(103);
            _codeList.Add(104);
            _codeList.Add(105);
            _codeList.Add(106);
            _codeList.Add(107);
            _codeList.Add(108);
            _codeList.Add(109);
            _codeList.Add(110);
            _codeList.Add(111);
            _codeList.Add(112);
            _codeList.Add(113);
            _codeList.Add(114);
            _codeList.Add(115);
            _codeList.Add(116);
            _codeList.Add(117);
            _codeList.Add(118);
            _codeList.Add(119);
            _codeList.Add(120);
            _codeList.Add(121);
            _codeList.Add(122);
            _codeList.Add(45);
            _codeList.Add(48);
            _codeList.Add(49);
            _codeList.Add(50);
            _codeList.Add(51);
            _codeList.Add(52);
            _codeList.Add(53);
            _codeList.Add(54);
            _codeList.Add(55);
            _codeList.Add(56);
            _codeList.Add(57);
            _codeList.Add(SPACE_CHAR);
            _codeList.Add(40);
            _codeList.Add(41);
            _codeList.Add(BACK_SPACE);
            

        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            try
            {
                int selectedChar = (int)e.KeyData;

                if (!_codeList.Contains(selectedChar))
                {
                    e.SuppressKeyPress = true;
                }


            }
            catch
            {

            }
            
           
        }

      
    }

}
