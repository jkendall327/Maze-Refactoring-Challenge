using System;
using System.IO;
using Maze;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class AmazingTests
	{
		private Amazing? _sut;

		[Test]
		public void Seed0size15x20() 
		{
			String expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
:--:--:--:--:--:--:--:--:--:--:  :--:--:--:--:
I                             I        I     I 
:  :--:--:--:--:  :--:--:  :--:  :--:--:  :--:
I           I     I     I  I     I     I     I 
:--:--:--:  :  :  :  :  :--:  :  :  :  :--:  :
I        I  I  I     I  I     I     I     I  I 
:--:  :  :--:  :  :--:  :  :--:--:--:--:  :  :
I     I  I     I     I     I  I           I  I 
:  :--:  :  :--:--:  :--:--:  :  :--:  :--:  :
I  I  I     I        I     I  I     I     I  I 
:  :  :  :--:  :--:--:  :--:  :--:  :--:  :  :
I  I  I     I  I     I        I     I  I  I  I 
:  :  :--:  :--:  :  :  :--:--:  :--:  :  :  :
I  I     I     I  I  I        I  I     I  I  I 
:  :  :  :--:  :--:  :--:  :  :  :  :--:  :  :
I  I  I     I     I  I     I  I  I        I  I 
:  :--:--:  :  :  :  :  :  :--:  :  :--:--:  :
I           I  I     I  I  I     I     I  I  I 
:--:--:--:--:  :--:--:  :  :  :--:--:  :  :  :
I     I  I        I     I  I  I        I     I 
:  :  :  :  :  :  :  :--:  :  :--:--:--:  :--:
I  I  I     I  I     I     I  I        I     I 
:--:  :  :--:  :--:--:  :--:  :  :--:  :--:  :
I     I  I     I        I     I  I     I  I  I 
:  :--:  :  :--:  :--:--:  :--:  :  :--:  :  :
I        I  I     I     I     I  I        I  I 
:  :--:--:  :--:--:  :  :--:  :  :--:--:  :  :
I        I     I     I     I  I  I     I     I 
:--:--:  :--:  :  :  :--:  :  :  :  :--:--:  :
I     I     I  I  I  I     I     I  I        I 
:  :  :--:  :  :  :  :  :--:--:--:  :  :--:--:
I  I        I     I  I           I  I  I     I 
:  :--:--:--:--:--:--:--:  :--:  :  :  :--:  :
I  I        I  I  I     I     I  I           I 
:  :--:  :  :--:--:  :  :--:  :--:--:--:--:--:
I     I  I  I     I  I  I           I        I 
:--:  :  :  :  :  :  :--:  :--:--:--:  :--:--:
I     I  I     I     I              I        I 
:  :--:--:--:--:  :  :  :  :  :--:  :--:--:  :
I                 I  I     I     I           I 
:--:--:--:--:--:--:--:--:--:--:--:  :--:--:--:
";

			_sut = new Amazing(new Random(0));

			var actual = _sut.DoIt(15, 20);

			Assert.AreEqual(expected, actual, "Should have the maze that was expected");
		}

		[Test]
		public void Seed100size4x5() 
		{
			String expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
:--:--:--:  :
I           I 
:  :--:  :--:
I     I  I  I 
:--:  :  :  :
I  I  I     I 
:  :  :--:  :
I  I     I  I 
:  :--:  :  :
I        I  I 
:--:--:--:  :
";

			_sut = new Amazing(new Random(100));
			var actual = _sut.DoIt(4, 5);

			Assert.AreEqual(expected, actual, "Should have the maze that was expected");
		}
	}
}
