// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace FaceApp {
	
	
	// Should subclass MonoMac.Foundation.NSObject
	[MonoMac.Foundation.Register("CustomWindow")]
	public partial class CustomWindow {
		
		private global::MonoMac.AppKit.NSSlider __mt_slider;
		
		#pragma warning disable 0169
		[MonoMac.Foundation.Connect("slider")]
		private global::MonoMac.AppKit.NSSlider slider {
			get {
				this.__mt_slider = ((global::MonoMac.AppKit.NSSlider)(this.GetNativeField("slider")));
				return this.__mt_slider;
			}
			set {
				this.__mt_slider = value;
				this.SetNativeField("slider", value);
			}
		}
	}
}