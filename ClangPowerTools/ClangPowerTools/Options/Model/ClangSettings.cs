using System;
using System.Collections.Generic;

namespace ClangPowerTools.Options.Model
{
  [Serializable]
  public class ClangSettings
  {

    #region Properties


    #region General Properties

    public List<string> ClangFlags { get; set; } = new List<string>();

    public List<string> FilesToIgnore { get; set; } = new List<string>();

    public List<string> ProjectsToIgnore { get; set; } = new List<string>();

    public ClangGeneralAdditionalIncludes? TreatAdditionalIncludesAs { get; set; }

    public bool TreatWarningsAsErrors { get; set; }

    public bool Continue { get; set; }

    public bool ClangCompileAfterVsCompile { get; set; }

    public bool VerboseMode { get; set; }

    public string Version { get; set; }


    #endregion


    #region Tidy Options Properties




    #endregion


    #endregion


  }
}
