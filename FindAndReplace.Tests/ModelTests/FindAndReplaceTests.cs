using FindReplace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindReplace.Test
{
  [TestClass]
  public class StringReplaceTest
  {
    [TestMethod]
    public void StringReplace_CreatesAStringReplaceObject_StringReplace()
    {
      StringReplace newStringReplace = new StringReplace("Original String", "Word", "Word2");
      Assert.AreEqual(typeof(StringReplace), newStringReplace.GetType());
    }

    [TestMethod]

    public void FindAndReplaceMethod_ReplacesWordWithNewWord_String()
    {
      StringReplace newStringReplace = new StringReplace("hello world", "world", "universe");
      Assert.AreEqual("hello universe", newStringReplace.FindAndReplaceMethod());
    }
  }
}