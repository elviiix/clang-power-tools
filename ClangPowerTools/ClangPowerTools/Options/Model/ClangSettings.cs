using System;
using System.Xml.Serialization;

namespace ClangPowerTools.Options.Model
{
  [Serializable]
  [XmlRoot(ElementName = "cpt-config")]
  public class ClangSettings
  {
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


    #region General Clang Properties






    #endregion



    #endregion


  }
}
