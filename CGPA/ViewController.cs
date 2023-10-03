using ObjCRuntime;

namespace CGPA;

public partial class ViewController : NSViewController {
	protected ViewController (NativeHandle handle) : base (handle)
	{
		// This constructor is required if the view controller is loaded from a xib or a storyboard.
		// Do not put any initialization here, use ViewDidLoad instead.
	}

	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();

		// Do any additional setup after loading the view.
	}

	public override NSObject RepresentedObject {
		get => base.RepresentedObject;
		set {
			base.RepresentedObject = value;

			// Update the view, if already loaded.
		}
	}

    partial void calculationBtn(NSButton sender)
    {
        // get marks
		int mat3131 = Convert.ToInt32(mat3131_marks.StringValue);
        int cse3122 = Convert.ToInt32(cse3122_marks.StringValue);
        int cse3133 = Convert.ToInt32(cse3133_marks.StringValue);
        int cse3134 = Convert.ToInt32(cse3134_marks.StringValue);
        int cse31p5 = Convert.ToInt32(cse31p5_marks.StringValue);
        int cse3136 = Convert.ToInt32(cse3136_marks.StringValue);
        int cse31p7 = Convert.ToInt32(cse31p7_marks.StringValue);
        int cse31p8 = Convert.ToInt32(cse31p8_marks.StringValue);
        int cse31p9 = Convert.ToInt32(cse31p9_marks.StringValue);

        double mat3131_point;
        double cse3122_point;
        double cse3133_point;
        double cse3134_point;
        double cse31p5_point;
        double cse3136_point;
        double cse31p7_point;
        double cse31p8_point;
        double cse31p9_point;


        // cal - grade - mat3131
        if (mat3131 < 40) { mat3131_grade.StringValue = "F"; mat3131_point = 0.0; }
        else if (mat3131 < 45) { mat3131_grade.StringValue = "D"; mat3131_point = 2.0; }
        else if (mat3131 < 50) { mat3131_grade.StringValue = "C"; mat3131_point = 2.25; }
        else if (mat3131 < 55) { mat3131_grade.StringValue = "C+"; mat3131_point = 2.50; }
        else if (mat3131 < 60) { mat3131_grade.StringValue = "B-"; mat3131_point = 2.75; }
        else if (mat3131 < 65) { mat3131_grade.StringValue = "B"; mat3131_point = 3.0; }
        else if (mat3131 < 70) { mat3131_grade.StringValue = "B+"; mat3131_point = 3.25; }
        else if (mat3131 < 75) { mat3131_grade.StringValue = "A-"; mat3131_point = 3.5; }
        else if (mat3131 < 80) { mat3131_grade.StringValue = "A"; mat3131_point = 3.75; }
        else { mat3131_grade.StringValue = "A+"; mat3131_point = 4.0; }

        // cal - grade - cse3122
        if (cse3122 < 40) { cse3122_grade.StringValue = "F"; cse3122_point = 0.0; }
        else if (cse3122 < 45) { cse3122_grade.StringValue = "D"; cse3122_point = 2.0; }
        else if (cse3122 < 50) { cse3122_grade.StringValue = "C"; cse3122_point = 2.25; }
        else if (cse3122 < 55) { cse3122_grade.StringValue = "C+"; cse3122_point = 2.5; }
        else if (cse3122 < 60) { cse3122_grade.StringValue = "B-"; cse3122_point = 2.75; }
        else if (cse3122 < 65) { cse3122_grade.StringValue = "B"; cse3122_point = 3.0; }
        else if (cse3122 < 70) { cse3122_grade.StringValue = "B+"; cse3122_point = 3.25; }
        else if (cse3122 < 75) { cse3122_grade.StringValue = "A-"; cse3122_point = 3.5; }
        else if (cse3122 < 80) { cse3122_grade.StringValue = "A"; cse3122_point = 3.75; }
        else { cse3122_grade.StringValue = "A+"; cse3122_point = 4.0; }

        // cal - grade - cse3133
        if (cse3133 < 40) { cse3133_grade.StringValue = "F"; cse3133_point = 0.0; }
        else if (cse3133 < 45) { cse3133_grade.StringValue = "D"; cse3133_point = 2.0; }
        else if (cse3133 < 50) { cse3133_grade.StringValue = "C"; cse3133_point = 2.25; }
        else if (cse3133 < 55) { cse3133_grade.StringValue = "C+"; cse3133_point = 2.5; }
        else if (cse3133 < 60) { cse3133_grade.StringValue = "B-"; cse3133_point = 2.75; }
        else if (cse3133 < 65) { cse3133_grade.StringValue = "B"; cse3133_point = 3.0; }
        else if (cse3133 < 70) { cse3133_grade.StringValue = "B+"; cse3133_point = 3.25; }
        else if (cse3133 < 75) { cse3133_grade.StringValue = "A-"; cse3133_point = 3.5; }
        else if (cse3133 < 80) { cse3133_grade.StringValue = "A"; cse3133_point = 3.75; }
        else { cse3133_grade.StringValue = "A+"; cse3133_point = 4.0; }

        // cal - grade - cse3134
        if (cse3134 < 40) { cse3134_grade.StringValue = "F"; cse3134_point = 0.0; }
        else if (cse3134 < 45) { cse3134_grade.StringValue = "D"; cse3134_point = 2.0; }
        else if (cse3134 < 50) { cse3134_grade.StringValue = "C"; cse3134_point = 2.25; }
        else if (cse3134 < 55) { cse3134_grade.StringValue = "C+"; cse3134_point = 2.5; }
        else if (cse3134 < 60) { cse3134_grade.StringValue = "B-"; cse3134_point = 2.75; }
        else if (cse3134 < 65) { cse3134_grade.StringValue = "B"; cse3134_point = 3.0; }
        else if (cse3134 < 70) { cse3134_grade.StringValue = "B+"; cse3134_point = 3.25; }
        else if (cse3134 < 75) { cse3134_grade.StringValue = "A-"; cse3134_point = 3.5; }
        else if (cse3134 < 80) { cse3134_grade.StringValue = "A"; cse3134_point = 3.75; }
        else { cse3134_grade.StringValue = "A+"; cse3134_point = 4.0; }

        // cal - grade - cse31p5
        if (cse31p5 < 40) { cse31p5_grade.StringValue = "F"; cse31p5_point = 0.0; }
        else if (cse31p5 < 45) { cse31p5_grade.StringValue = "D"; cse31p5_point = 2.0; }
        else if (cse31p5 < 50) { cse31p5_grade.StringValue = "C"; cse31p5_point = 2.25; }
        else if (cse31p5 < 55) { cse31p5_grade.StringValue = "C+"; cse31p5_point = 2.5; }
        else if (cse31p5 < 60) { cse31p5_grade.StringValue = "B-"; cse31p5_point = 2.75; }
        else if (cse31p5 < 65) { cse31p5_grade.StringValue = "B"; cse31p5_point = 3.0; }
        else if (cse31p5 < 70) { cse31p5_grade.StringValue = "B+"; cse31p5_point = 3.25; }
        else if (cse31p5 < 75) { cse31p5_grade.StringValue = "A-"; cse31p5_point = 3.5; }
        else if (cse31p5 < 80) { cse31p5_grade.StringValue = "A"; cse31p5_point = 3.75; }
        else { cse31p5_grade.StringValue = "A+"; cse31p5_point = 4.0; }

        // cal - grade - cse3136
        if (cse3136 < 40) { cse3136_grade.StringValue = "F"; cse3136_point = 0.0; }
        else if (cse3136 < 45) { cse3136_grade.StringValue = "D"; cse3136_point = 2.0; }
        else if (cse3136 < 50) { cse3136_grade.StringValue = "C"; cse3136_point = 2.25; }
        else if (cse3136 < 55) { cse3136_grade.StringValue = "C+"; cse3136_point = 2.5; }
        else if (cse3136 < 60) { cse3136_grade.StringValue = "B-"; cse3136_point = 2.75; }
        else if (cse3136 < 65) { cse3136_grade.StringValue = "B"; cse3136_point = 3.0; }
        else if (cse3136 < 70) { cse3136_grade.StringValue = "B+"; cse3136_point = 3.25; }
        else if (cse3136 < 75) { cse3136_grade.StringValue = "A-"; cse3136_point = 3.5; }
        else if (cse3136 < 80) { cse3136_grade.StringValue = "A"; cse3136_point = 3.75; }
        else { cse3136_grade.StringValue = "A+"; cse3136_point = 4.0; }

        // cal - grade - cse31p7
        if (cse31p7 < 40) { cse31p7_grade.StringValue = "F"; cse31p7_point = 0.0; }
        else if (cse31p7 < 45) { cse31p7_grade.StringValue = "D"; cse31p7_point = 2.0; }
        else if (cse31p7 < 50) { cse31p7_grade.StringValue = "C"; cse31p7_point = 2.25; }
        else if (cse31p7 < 55) { cse31p7_grade.StringValue = "C+"; cse31p7_point = 2.5; }
        else if (cse31p7 < 60) { cse31p7_grade.StringValue = "B-"; cse31p7_point = 2.75; }
        else if (cse31p7 < 65) { cse31p7_grade.StringValue = "B"; cse31p7_point = 3.0; }
        else if (cse31p7 < 70) { cse31p7_grade.StringValue = "B+"; cse31p7_point = 3.25; }
        else if (cse31p7 < 75) { cse31p7_grade.StringValue = "A-"; cse31p7_point = 3.5; }
        else if (cse31p7 < 80) { cse31p7_grade.StringValue = "A"; cse31p7_point = 3.75; }
        else { cse31p7_grade.StringValue = "A+"; cse31p7_point = 4.0; }

        // cal - grade - cse31p8
        if (cse31p8 < 40) { cse31p8_grade.StringValue = "F"; cse31p8_point = 0.0; }
        else if (cse31p8 < 45) { cse31p8_grade.StringValue = "D"; cse31p8_point = 2.0; }
        else if (cse31p8 < 50) { cse31p8_grade.StringValue = "C"; cse31p8_point = 2.25; }
        else if (cse31p8 < 55) { cse31p8_grade.StringValue = "C+"; cse31p8_point = 2.5; }
        else if (cse31p8 < 60) { cse31p8_grade.StringValue = "B-"; cse31p8_point = 2.75; }
        else if (cse31p8 < 65) { cse31p8_grade.StringValue = "B"; cse31p8_point = 3.0; }
        else if (cse31p8 < 70) { cse31p8_grade.StringValue = "B+"; cse31p8_point = 3.25; }
        else if (cse31p8 < 75) { cse31p8_grade.StringValue = "A-"; cse31p8_point = 3.5; }
        else if (cse31p8 < 80) { cse31p8_grade.StringValue = "A"; cse31p8_point = 3.75; }
        else { cse31p8_grade.StringValue = "A+"; cse31p8_point = 4.0; }

        // cal - grade - cse31p9
        if (cse31p9 < 40) { cse31p9_grade.StringValue = "F"; cse31p9_point = 0.0; }
        else if (cse31p9 < 45) { cse31p9_grade.StringValue = "D"; cse31p9_point = 2.0; }
        else if (cse31p9 < 50) { cse31p9_grade.StringValue = "C"; cse31p9_point = 2.25; }
        else if (cse31p9 < 55) { cse31p9_grade.StringValue = "C+"; cse31p9_point = 2.5; }
        else if (cse31p9 < 60) { cse31p9_grade.StringValue = "B-"; cse31p9_point = 2.75; }
        else if (cse31p9 < 65) { cse31p9_grade.StringValue = "B"; cse31p9_point = 3.0; }
        else if (cse31p9 < 70) { cse31p9_grade.StringValue = "B+"; cse31p9_point = 3.25; }
        else if (cse31p9 < 75) { cse31p9_grade.StringValue = "A-"; cse31p9_point = 3.5; }
        else if (cse31p9 < 80) { cse31p9_grade.StringValue = "A"; cse31p9_point = 3.75; }
        else { cse31p9_grade.StringValue = "A+"; cse31p9_point = 4.0; }

        // gpa cal

        double value = (mat3131_point* 3.0) + (cse3122_point * 2.0) + (cse3133_point * 3.0) + (cse3134_point * 3.0) + (cse31p5_point * 1.5) + (cse3136_point * 3.0) + (cse31p7_point * 1.5) + (cse31p8_point * 1.5) + (cse31p9_point * 1.5);
        double GPA = Math.Round((value / 20.0), 2);

        string gpa_str = Convert.ToString(GPA);
        total_gpa.StringValue = gpa_str;

        // total grade

        if (GPA <= 0.0) total_grade.StringValue = "F";
        else if (GPA <=  2.0) total_grade.StringValue = "D";
        else if (GPA <= 2.25) total_grade.StringValue = "C";
        else if (GPA <= 2.50) total_grade.StringValue = "C+";
        else if (GPA <= 2.75) total_grade.StringValue = "B-";
        else if (GPA <= 3.0) total_grade.StringValue = "B";
        else if (GPA <= 3.25) total_grade.StringValue = "B+";
        else if (GPA <= 3.50) total_grade.StringValue = "A-";
        else if (GPA <= 3.75) total_grade.StringValue = "A";
        else total_grade.StringValue = "A+";
    }
}

