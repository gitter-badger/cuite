﻿#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightControl : SilverlightControl<CUITControls.SilverlightControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightControl"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightControl(By searchConfiguration = null)
            : this(new CUITControls.SilverlightControl(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightControl"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightControl(CUITControls.SilverlightControl sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif