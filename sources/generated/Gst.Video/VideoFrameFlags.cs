// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Video.VideoFrameFlagsGType))]
	public enum VideoFrameFlags {

		None = 0,
		Interlaced = 1,
		Tff = 2,
		Rff = 4,
		Onefield = 8,
		BottomField = 8,
		TopField = 10,
		MultipleView = 16,
		FirstInBundle = 32,
	}

	internal class VideoFrameFlagsGType {
		[DllImport ("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_frame_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_frame_flags_get_type ());
			}
		}
	}
#endregion
}