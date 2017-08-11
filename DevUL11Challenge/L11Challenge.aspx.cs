using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUL11Challenge
{
	public partial class L11Challenge : System.Web.UI.Page
	{


		protected void Page_Load(object sender, EventArgs e)
		{

		}

		public class Course
		{
			public string name { get; set; }
			public string[] students { get; set; }
			public string description { get; set; }

			// public string student { get; set; }
		}
		public class Student
		{
			public int StudentId { get; set; }
			public string name { get; set; }
			public List<Course> Courses { get; set; }
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			/*
			Course course1 = new Course();
			course1.name = "underwater basket weaving";
			course1.students = new string[] { "bo peep", "curious george", "popeye" };
			course1.description = "Get ready to learn different underwater basket weaving techniques! " +
				"Scuba gear not included in tuition";
			*/
			/*
			List<Course> listOfCourses = new List<Course>()
			{
				new Course() { name = "underwater basket weaving", students = new List<Student>(){
					new Student(){StudentId=1, name="bo peep")}
			}
			*/
		}	
	}

			listOfCourses.Add(course1);
			foreach (Course course in listOfCourses)
			{
				resultLabel.Text += course.FormatDetailsForDisplay();

			}
}