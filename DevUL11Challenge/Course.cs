﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevUL11Challenge
{
	
	public class Course
	{
		public int CourseId {get;set;}
		public string Name {get;set;}
		public List<Student> Students {get;set;}
	}
	
}