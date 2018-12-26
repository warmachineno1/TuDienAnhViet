//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.ComponentModel;
//using System.Runtime.InteropServices;
//using System.Windows.Forms;
//using System.Drawing;

//namespace DoAnCK_TDN
//{
//    class ElipseControl : Component
//    {
//        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRec")]
//        private static extern IntPtr CreateRoundRec
//        (
//             int nLeftRec,
//             int nTopRec,
//             int nRightRec,
//             int nBottomRec,
//             int nWidthEllipse,
//             int nHeightEllipse
//        );
//        private Control _cntr;
//        private int _CornerRadius = 30;

//        public Control TargetControl
//        {
//            get { return _cntr; }
//            set
//            {
//                _cntr = value;
//                _cntr.SizeChanged += (sender, EventArgs) => _cntr.Region = Region.FromHrgn(CreateRoundRec(0, 0, _cntr.Width, _cntr.Height, _CornerRadius, _CornerRadius));

//            }
//        }
//        public int CornerRadius
//        {
//            get { return _CornerRadius; }
//            set
//            {
//                _CornerRadius = value;
//                if (_cntr != null)
//                    _cntr.Region = Region.FromHrgn(CreateRoundRec(0, 0, _cntr.Width, _cntr.Height, _CornerRadius, _CornerRadius));
//            }
//        }
//    }
//}
