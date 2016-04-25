using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPets.Miscellaneous {
  public static class StringUtilities {

    public static string Times(this string text, int n) {
      string result = "";
      while (n-- > 0) result += text;
      return result;
      }

    }
  }
