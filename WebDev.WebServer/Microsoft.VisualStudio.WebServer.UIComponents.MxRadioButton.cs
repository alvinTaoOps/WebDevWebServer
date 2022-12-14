namespace Microsoft.VisualStudio.WebServer.UIComponents
{
    using System;
    using System.Windows.Forms;

    public class MxRadioButton : RadioButton
    {
        public MxRadioButton()
        {
            if (MxTheme.IsAppThemed)
            {
                base.FlatStyle = FlatStyle.System;
            }
            else
            {
                base.FlatStyle = FlatStyle.Popup;
            }
        }

        private bool ShouldSerializeFlatStyle()
        {
            return false;
        }
    }
}
