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
			List<Course> courses = new List<Course>(){
				new Course()
					{ CourseId =1, Name="Dream Interpretation", Students=new List<Student>()
						{
						new Student(){ StudentId=1, Name="Bo Peep" },
						new Student(){ StudentId=2, Name="Curious George"}
						}
					},
				new Course() { CourseId =2, Name="Day Dreaming", Students=new List<Student>() {
					new Student(){ StudentId=3, Name="Bob Peep" },
					new Student(){ StudentId=4, Name="Curiously George"} } },

				new Course(){
					CourseId =3, Name="Lucid Dreaming", Students=new List<Student>(){
						new Student(){
							StudentId =5, Name="Bobby Peep"
						},
						new Student(){
							StudentId =6, Name="Intrigued George"
						}
					}
				}
			};

			foreach ( var course in courses )
			{
				resultLabel.Text += String.Format("<br/>{0}-{1}", course.CourseId, course.Name);
				
				foreach (var student in course.Students)
				{
					resultLabel.Text += String.Format("<br/>&nbsp;&nbsp;Student:{0} - {1} ", student.StudentId, student.Name);
				}
				
			}
		}

		

		protected void Button2_Click(object sender, EventArgs e)
		{

		}
	}
}