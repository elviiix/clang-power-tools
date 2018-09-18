using System;
using System.Xml.Serialization;

namespace ClangPowerTools.Options.Model
{
  [Serializable]
  public class ScriptXmlElement
  {
    #region General Properties 


    [XmlElement("clang-flags")]
    public string ClangFlags { get; set; }


    [XmlElement("file-ignore")]
    public string FilesToIgnore { get; set; }


    [XmlElement("proj-ignore")]
    public string ProjectsToIgnore { get; set; }


    [XmlElement("treat-sai")]
    public ClangGeneralAdditionalIncludes? TreatAdditionalIncludesAs { get; set; }


    [XmlElement("continue")] public bool Continue { get; set; } = true;
    public bool ShouldSerializeContinue => true == Continue;


    #endregion


    #region Tidy Options Properties


    [XmlElement("tidy")]
    public string TidyCustomChecks { get; set; }


    [XmlElement("format-style")] public bool FormatAfterTidy { get; set; }
    public bool ShouldSerializeFormatAfterTidy => true == FormatAfterTidy;


    [XmlElement("header-filter")]
    public string HeaderFilter { get; set; }


    #endregion

  }


  [Serializable]
  public class ExtensionXmlElement
  {
    #region General Properties


    [XmlElement] public bool TreatWarningsAsErrors { get; set; }
    public bool ShouldSerializeTreatWarningsAsErrors => true == TreatWarningsAsErrors;


    [XmlElement] public bool ClangCompileAfterVsCompile { get; set; }
    public bool ShouldSerializeClangCompileAfterVsCompile => true == ClangCompileAfterVsCompile;


    [XmlElement] public bool VerboseMode { get; set; }
    public bool ShouldSerializeVerboseMode => true == VerboseMode;

    public string Version { get; set; }


    #endregion


    #region Format Properties


    #region Format On Save

    [XmlElement] public bool FormatOnSave { get; set; }
    public bool ShouldSerializeFormatOnSave => true == FormatOnSave;


    public string FileExtensions { get; set; }

    public string FormatSkipFiles { get; set; }

    #endregion


    #region Format Options

    public string AssumeFilename { get; set; }

    public ClangFormatFallbackStyle? FallbackStyle { get; set; }

    //public bool SortIncludes { get; set; }

    public ClangFormatStyle? Style { get; set; }


    #endregion


    #region Clang-Format executable path

    public ClangFormatPathValue ClangFormatPath { get; set; }

    #endregion


    #endregion


    #region Tidy Options Properties


    [XmlElement] public bool TidyOnSave { get; set; }
    public bool ShouldSerializeTidyOnSave => true == TidyOnSave;


    public ClangTidyUseChecksFrom? UseChecksFrom { get; set; }

    #endregion
  }


  [Serializable]
  [XmlRoot(ElementName = "cpt-config")]
  public class ClangSettings
  {
    #region Properties


    [XmlElement("ScriptOptions")]
    public ScriptXmlElement ScriptXmlElements { get; set; }


    [XmlElement("ExtensionOptions")]
    public ExtensionXmlElement ExtensionXmlElements { get; set; }


    #endregion

  }
}
