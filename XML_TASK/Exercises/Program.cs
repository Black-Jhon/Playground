using System;

namespace Exercises
{
    /// <summary>
    /// Writing code is not difficult. Writing Clean and Scalable Code is not easy as well.
    /// Right here, we will talk about 15 Tips to write Clean C# Code for one's projects.
    /// </summary>
    
    internal class Program
    {
        /// <summary>
        /// 1. Use a Good IDE eg: Visual Studio 2022, Jetbrains Rider IDE etc
        /// 2. Use Meaningful Names
        /// example: int age; makes more sense as it is more expressive when you compare it with int d;
        /// 3. Use Camel/Pascal Case Notation eg string firstName against using string firstname.
        /// 4. Pay attention to Formatting eg
        ///     The below code is a bad way of formatting one's code 
        ///     class Program
        ///     {static void Main(string[] args)
        ///         {Console.WriteLine("Hello World!");
        ///         }
        ///     }
        ///
        ///     The below code is a better way of formatting one's code as it improves readability.
        ///     class Program
        ///     {
        ///         static void Main(string[] args)
        ///         {
        ///             Console.WriteLine("Hello World!");
        ///         }
        ///     }
        ///
        /// 5. Add Comments Whenever Necessary
        /// 6. Reuse Code
		/// 7. Keep Class Size Small
		///	8. Use Design Patterns
		/// 9. Structure your Solution well
		/// 10. Avoid Magic Strings/Numbers
		/// 
		/// 	Example:
		///		Instead of this, 
		///		if(userRole == "Admin")
		///		{
    	///			logic here
		///		}
		/// 
		///		Do this instead
		///		const string ADMIN_ROLE = "Admin"
		///		if(userRole == ADMIN_ROLE )
		///		{
        ///			logic here
		///		}
		///
		/// 11. Remove Unused Code
		/// 12. Don’t use ‘throw ex’ in the catch block
		///
		///		Example
		///		So instead of
		///		try
		///		{ 
		///			Do something..
		///		}
		///		catch (Exception ex)
		///		{
		///			throw ex;
		///		}
		///
		///		Do this instead
		///		try
		///		{
		///			 Do something..
		///		}
		///			catch (Exception ex)
		///		{
		///			throw;
		///		}
		///
		/// 13.Prefer String Interpolation
		///
		///		Instead of
		///		public string SomeMethod(Student student)
		///		{
		///			return "Student Name is " + student.Name + ". Age is " + student.Age;
		///		}
		///
		///		Do this instead
        ///		public string SomeMethod(Student student)
        ///		{
        ///			return $"Student Name is {student.Name}. Age is {student.Age}";
        ///		}
        ///
        /// 14. Use Expression Bodied Methods
        ///		Eg: public string Message() => "Hello World!";
        ///
        /// 15. Don’t ignore caught errors
        ///
        ///		Instead of
        ///		public void SomeMethod()
        ///		{
        ///			try
	    ///			{
        ///				DoSomething();
	    ///			}
	    ///			catch
	    ///			{
	    ///		    }
        ///		}
        ///
        ///		Do this instead
        ///		public void SomeMethod()
        ///		{
        ///			try
        ///			{
        ///				DoSomething();
        ///			}
        ///			 catch (Exception ex)
        ///			{
        ///				LogItSomewhere(ex);
        ///		    }
        ///		}
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
