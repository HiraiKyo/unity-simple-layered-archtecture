using System;

public static class CommonFunctions {
  public static string GenUUID() {
    var guid = Guid.NewGuid();
    return guid.ToString();
  }
}