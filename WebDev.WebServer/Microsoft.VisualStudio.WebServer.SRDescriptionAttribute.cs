namespace Microsoft.VisualStudio.WebServer
{
    using System;
    using System.ComponentModel;

    [AttributeUsage(AttributeTargets.All)]
    internal sealed class SRDescriptionAttribute : DescriptionAttribute
    {
        private bool replaced;

        public SRDescriptionAttribute(string description) : base(description)
        {
        }

        public override string Description
        {
            get
            {
                if (!this.replaced)
                {
                    this.replaced = true;
                    base.DescriptionValue = Microsoft.VisualStudio.WebServer.SR.GetString(base.Description);
                }
                return base.Description;
            }
        }
    }
}
