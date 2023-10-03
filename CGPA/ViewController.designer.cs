// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CGPA
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField cse3122_grade { get; set; }

		[Outlet]
		AppKit.NSTextField cse3122_marks { get; set; }

		[Outlet]
		AppKit.NSTextField cse3133_grade { get; set; }

		[Outlet]
		AppKit.NSTextField cse3133_marks { get; set; }

		[Outlet]
		AppKit.NSTextField cse3134_grade { get; set; }

		[Outlet]
		AppKit.NSTextField cse3134_marks { get; set; }

		[Outlet]
		AppKit.NSTextField cse3136_grade { get; set; }

		[Outlet]
		AppKit.NSTextField cse3136_marks { get; set; }

		[Outlet]
		AppKit.NSTextField cse31p5_grade { get; set; }

		[Outlet]
		AppKit.NSTextField cse31p5_marks { get; set; }

		[Outlet]
		AppKit.NSTextField cse31p7_grade { get; set; }

		[Outlet]
		AppKit.NSTextField cse31p7_marks { get; set; }

		[Outlet]
		AppKit.NSTextField cse31p8_grade { get; set; }

		[Outlet]
		AppKit.NSTextField cse31p8_marks { get; set; }

		[Outlet]
		AppKit.NSTextField cse31p9_grade { get; set; }

		[Outlet]
		AppKit.NSTextField cse31p9_marks { get; set; }

		[Outlet]
		AppKit.NSTextField mat3131_grade { get; set; }

		[Outlet]
		AppKit.NSTextField mat3131_marks { get; set; }

		[Outlet]
		AppKit.NSTextField total_gpa { get; set; }

		[Outlet]
		AppKit.NSTextField total_grade { get; set; }

		[Action ("calculationBtn:")]
		partial void calculationBtn (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (mat3131_marks != null) {
				mat3131_marks.Dispose ();
				mat3131_marks = null;
			}

			if (cse3122_marks != null) {
				cse3122_marks.Dispose ();
				cse3122_marks = null;
			}

			if (cse3133_marks != null) {
				cse3133_marks.Dispose ();
				cse3133_marks = null;
			}

			if (cse3134_marks != null) {
				cse3134_marks.Dispose ();
				cse3134_marks = null;
			}

			if (cse31p5_marks != null) {
				cse31p5_marks.Dispose ();
				cse31p5_marks = null;
			}

			if (cse3136_marks != null) {
				cse3136_marks.Dispose ();
				cse3136_marks = null;
			}

			if (cse31p7_marks != null) {
				cse31p7_marks.Dispose ();
				cse31p7_marks = null;
			}

			if (cse31p8_marks != null) {
				cse31p8_marks.Dispose ();
				cse31p8_marks = null;
			}

			if (cse31p9_marks != null) {
				cse31p9_marks.Dispose ();
				cse31p9_marks = null;
			}

			if (mat3131_grade != null) {
				mat3131_grade.Dispose ();
				mat3131_grade = null;
			}

			if (cse3122_grade != null) {
				cse3122_grade.Dispose ();
				cse3122_grade = null;
			}

			if (cse3133_grade != null) {
				cse3133_grade.Dispose ();
				cse3133_grade = null;
			}

			if (cse3134_grade != null) {
				cse3134_grade.Dispose ();
				cse3134_grade = null;
			}

			if (cse31p5_grade != null) {
				cse31p5_grade.Dispose ();
				cse31p5_grade = null;
			}

			if (cse3136_grade != null) {
				cse3136_grade.Dispose ();
				cse3136_grade = null;
			}

			if (cse31p7_grade != null) {
				cse31p7_grade.Dispose ();
				cse31p7_grade = null;
			}

			if (cse31p8_grade != null) {
				cse31p8_grade.Dispose ();
				cse31p8_grade = null;
			}

			if (cse31p9_grade != null) {
				cse31p9_grade.Dispose ();
				cse31p9_grade = null;
			}

			if (total_gpa != null) {
				total_gpa.Dispose ();
				total_gpa = null;
			}

			if (total_grade != null) {
				total_grade.Dispose ();
				total_grade = null;
			}
		}
	}
}
