using System;
using System.Xml.Serialization;

namespace ClangPowerTools.Options.Model
{
  [Serializable]
  [XmlRoot(ElementName = "cpt-config")]
  public class ClangSettings
  {
    #region Members


    private string mConfigFilePath; 


    #endregion



    #region   Properties


    #region Script Properties

    [XmlElement("proj")]
    public string Project { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeProject() => !string.IsNullOrWhiteSpace(Project);



    [XmlElement("dir")]
    public string SolutionsPath { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeSolutionsPath() => !string.IsNullOrWhiteSpace(SolutionsPath);



    [XmlElement("proj-ignore")]
    public string ProjectsToIgnore { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeProjectsToIgnore() => !string.IsNullOrWhiteSpace(ProjectsToIgnore);



    [XmlElement("active-config")]
    public string ConfigurationPlatform { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeConfigurationPlatform() => !string.IsNullOrWhiteSpace(ConfigurationPlatform);



    [XmlElement("file")]
    public string File { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeFile() => !string.IsNullOrWhiteSpace(File);



    [XmlElement("file-ignore")]
    public string FilesToIgnore { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeFilesToIgnore() => !string.IsNullOrWhiteSpace(FilesToIgnore);



    [XmlElement("parallel")]
    public bool Parallel { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeParallel() => Parallel;



    [XmlElement("continue")]
    public bool Continue { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeContinue() => Continue;



    [XmlElement("treat-sai")]
    public ClangGeneralAdditionalIncludes? AdditionalIncludes { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeAdditionalIncludes() => null != AdditionalIncludes;



    [XmlElement("clang-flags")]
    public string ClangFlags { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeClangFlags() => !string.IsNullOrWhiteSpace(ClangFlags);



    [XmlElement("literal")]
    public bool Literal { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeLiteral() => Literal;



    [XmlElement("tidy")]
    public string TidyFlags { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeTidyFlags() => !string.IsNullOrWhiteSpace(TidyFlags);



    [XmlElement("tidy-fix")]
    public string TidyFixFlags { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeTidyFixFlags() => !string.IsNullOrWhiteSpace(TidyFixFlags);



    [XmlElement("header-filter")]
    public string HeaderFilter { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeHeaderFilter() => !string.IsNullOrWhiteSpace(HeaderFilter);



    [XmlElement("format-style")]
    public bool FormatAfterTidy { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeFormatAfterTidy() => FormatAfterTidy;



    [XmlElement("vs-ver")]
    public string VisualStudioVersion { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeVisualStudioVersion() => !string.IsNullOrWhiteSpace(VisualStudioVersion);



    [XmlElement("vs-sku")]
    public string VisualStudioEdition { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeVisualStudioEdition() => !string.IsNullOrWhiteSpace(VisualStudioEdition);


    #endregion


    #region Clang General Properties


    [XmlElement("treat-warnings-as-errors-vsix")]
    public bool TreatWarningsAsErrors { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeTreatWarningsAsErrors() => TreatWarningsAsErrors;



    [XmlElement("clang-compile-after-vs-compile-vsix")]
    public bool ClangCompileAfterVsCompile { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeClangCompileAfterVsCompile() => ClangCompileAfterVsCompile;



    [XmlElement("verbose-mode-vsix")]
    public bool VerboseMode { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeVerboseMode() => VerboseMode;



    [XmlElement("version-vsix")]
    public string Version { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeVersion() => null != Version;


    #endregion


    #region Tidy Options Properties


    // ClangTidyChecks is the same as the parameters: tidy and tidy-fix from the script parameters section


    [XmlElement("tidy-on-save-vsix")]
    public bool TidyOnSave { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeTidyOnSave() => TidyOnSave;


    [XmlElement("tidy-use-checks-from-vsix")]
    public ClangTidyUseChecksFrom? TidyUseChecksFrom { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeTidyUseChecksFrom() => null != TidyUseChecksFrom;



    #endregion



    #region Properties 


    #region Format On Save

    [XmlElement("format-on-save-vsix")]
    public bool FormatOnSave { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeFormatOnSave() => FormatOnSave;



    [XmlElement("file-extensions-vsix")]
    public string FileExtensions { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeFileExtensions() => !string.IsNullOrWhiteSpace(FileExtensions);



    [XmlElement("skip-files-vsix")]
    public string SkipFiles { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeSkipFiles() => !string.IsNullOrWhiteSpace(SkipFiles);


    #endregion


    #region Format Options


    [XmlElement("assume-filename-vsix")]
    public string AssumeFilename { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeAssumeFilename() => !string.IsNullOrWhiteSpace(AssumeFilename);



    [XmlElement("fallback-style-vsix")]
    public ClangFormatFallbackStyle? FallbackStyle { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeFallbackStyle() => null != FallbackStyle;


    //public bool SortIncludes { get; set; }


    [XmlElement("style-vsix")]
    public ClangFormatStyle? Style { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeStyle() => null != Style;


    #endregion


    #region Clang-Format executable path


    [XmlElement("clang-format-path-vsix")]
    public ClangFormatPathValue ClangFormatPath { get; set; }
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
    public bool ShouldSerializeClangFormatPath() => null != ClangFormatPath && !string.IsNullOrWhiteSpace(ClangFormatPath.Value);


    #endregion


    #endregion


    #endregion


  }
}
