using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace WinIPSWDecryptor.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		public static Settings Default
		{
			// Token: 0x0600001A RID: 26 RVA: 0x000041B1 File Offset: 0x000023B1
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400002C RID: 44
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
