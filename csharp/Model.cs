// Generated from mzTab_m_openapi.yml
// Timestamp: 2025-07-30

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MzTabM.Model
{
    // Enums
    public enum Prefix
    {
        COM
    }

    public enum Prefix1
    {
        MTD
    }

    public enum Prefix2
    {
        SML
    }

    public enum HeaderPrefix
    {
        SMH
    }

    public enum Prefix3
    {
        SMF
    }

    public enum HeaderPrefix1
    {
        SFH
    }

    public enum Prefix4
    {
        SME
    }

    public enum HeaderPrefix2
    {
        SEH
    }

    public enum Type
    {
        [JsonPropertyName("doi")]
        Doi,
        [JsonPropertyName("pubmed")]
        Pubmed,
        [JsonPropertyName("uri")]
        Uri
    }

    public enum Category
    {
        [JsonPropertyName("format")]
        Format,
        [JsonPropertyName("logical")]
        Logical,
        [JsonPropertyName("cross_check")]
        CrossCheck
    }

    public enum MessageType
    {
        [JsonPropertyName("error")]
        Error,
        [JsonPropertyName("warn")]
        Warn,
        [JsonPropertyName("info")]
        Info
    }

    // Classes
    public class Comment
    {
        [Required]
        public Prefix Prefix { get; set; }
        
        [Required]
        public string Msg { get; set; }
        
        [JsonPropertyName("line_number")]
        public int? LineNumber { get; set; }
    }

    public class Parameter
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        [JsonPropertyName("cv_label")]
        public string CvLabel { get; set; } = "";
        
        [JsonPropertyName("cv_accession")]
        public string CvAccession { get; set; } = "";
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Value { get; set; }
    }

    public class Instrument
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        public Parameter Name { get; set; }
        
        public Parameter Source { get; set; }
        
        public List<Parameter> Analyzer { get; set; } = new List<Parameter>();
        
        public Parameter Detector { get; set; }
    }

    public class SampleProcessing
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        [JsonPropertyName("sampleProcessing")]
        public List<Parameter> SampleProcessingParams { get; set; } = new List<Parameter>();
    }

    public class Software
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        public Parameter Parameter { get; set; }
        
        public List<string> Setting { get; set; } = new List<string>();
    }

    public class PublicationItem
    {
        [Required]
        public Type Type { get; set; }
        
        [Required]
        public string Accession { get; set; }
    }

    public class StringList
    {
        [Required]
        public List<string> Values { get; set; }
    }

    public class Contact
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        public string Name { get; set; }
        
        public string Affiliation { get; set; }
        
        [EmailAddress]
        [RegularExpression(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$")]
        public string Email { get; set; }
        
        [RegularExpression(@"^[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{3}[0-9X]{1}$")]
        public string Orcid { get; set; }
    }

    public class Uri
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        [Url]
        public string Value { get; set; }
    }

    public class Sample
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        public string Name { get; set; }
        
        public List<Parameter> Custom { get; set; } = new List<Parameter>();
        
        public List<Parameter> Species { get; set; } = new List<Parameter>();
        
        public List<Parameter> Tissue { get; set; } = new List<Parameter>();
        
        [JsonPropertyName("cell_type")]
        public List<Parameter> CellType { get; set; } = new List<Parameter>();
        
        public List<Parameter> Disease { get; set; } = new List<Parameter>();
        
        public string Description { get; set; }
    }

    public class MsRun
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        [Required]
        [Url]
        public string Location { get; set; }
        
        [JsonPropertyName("instrument_ref")]
        public Instrument InstrumentRef { get; set; }
        
        public Parameter Format { get; set; }
        
        [JsonPropertyName("id_format")]
        public Parameter IdFormat { get; set; }
        
        [JsonPropertyName("fragmentation_method")]
        public List<Parameter> FragmentationMethod { get; set; } = new List<Parameter>();
        
        [JsonPropertyName("scan_polarity")]
        public List<Parameter> ScanPolarity { get; set; } = new List<Parameter>();
        
        public string Hash { get; set; }
        
        [JsonPropertyName("hash_method")]
        public Parameter HashMethod { get; set; }
    }

    public class Assay
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public List<Parameter> Custom { get; set; } = new List<Parameter>();
        
        [JsonPropertyName("external_uri")]
        [Url]
        public string ExternalUri { get; set; }
        
        [JsonPropertyName("sample_ref")]
        public Sample SampleRef { get; set; }
        
        [Required]
        [JsonPropertyName("ms_run_ref")]
        [MinLength(1)]
        public List<MsRun> MsRunRef { get; set; }
    }

    public class CV
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        [Required]
        public string Label { get; set; }
        
        [Required]
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
        
        [Required]
        public string Version { get; set; }
        
        [Required]
        [Url]
        public string Uri { get; set; }
    }

    public class Database
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        [Required]
        public Parameter Param { get; set; }
        
        [Required]
        public string Prefix { get; set; }
        
        [Required]
        public string Version { get; set; }
        
        [Required]
        [Url]
        public string Uri { get; set; }
    }

    public class ColumnParameterMapping
    {
        [Required]
        [JsonPropertyName("column_name")]
        public string ColumnName { get; set; }
        
        [Required]
        public Parameter Param { get; set; }
    }

    public class OptColumnMapping
    {
        [Required]
        public string Identifier { get; set; }
        
        public Parameter Param { get; set; }
        
        public string Value { get; set; }
    }

    public class Error
    {
        [Required]
        public int Code { get; set; }
        
        [Required]
        public string Message { get; set; }
    }

    public class ValidationMessage
    {
        [Required]
        public string Code { get; set; }
        
        [Required]
        public Category Category { get; set; }
        
        [JsonPropertyName("message_type")]
        public MessageType MessageType { get; set; } = MessageType.Info;
        
        [Required]
        public string Message { get; set; }
        
        [JsonPropertyName("line_number")]
        public int? LineNumber { get; set; }
    }

    public class SmallMoleculeSummary
    {
        public Prefix2 Prefix { get; set; } = Prefix2.SML;
        
        [JsonPropertyName("header_prefix")]
        public HeaderPrefix HeaderPrefix { get; set; } = HeaderPrefix.SMH;
        
        [Required]
        [JsonPropertyName("sml_id")]
        public int SmlId { get; set; }
        
        [JsonPropertyName("smf_id_refs")]
        public List<int> SmfIdRefs { get; set; } = new List<int>();
        
        [JsonPropertyName("database_identifier")]
        public List<string> DatabaseIdentifier { get; set; } = new List<string>();
        
        [JsonPropertyName("chemical_formula")]
        public List<string> ChemicalFormula { get; set; } = new List<string>();
        
        public List<string> Smiles { get; set; } = new List<string>();
        
        public List<string> Inchi { get; set; } = new List<string>();
        
        [JsonPropertyName("chemical_name")]
        public List<string> ChemicalName { get; set; } = new List<string>();
        
        public List<string> Uri { get; set; } = new List<string>();
        
        [JsonPropertyName("theoretical_neutral_mass")]
        public List<double?> TheoreticalNeutralMass { get; set; } = new List<double?>();
        
        [JsonPropertyName("adduct_ions")]
        public List<string> AdductIons { get; set; } = new List<string>();
        
        public string Reliability { get; set; }
        
        [JsonPropertyName("best_id_confidence_measure")]
        public Parameter BestIdConfidenceMeasure { get; set; }
        
        [JsonPropertyName("best_id_confidence_value")]
        public double? BestIdConfidenceValue { get; set; }
        
        [JsonPropertyName("abundance_assay")]
        public List<double?> AbundanceAssay { get; set; } = new List<double?>();
        
        [JsonPropertyName("abundance_study_variable")]
        public List<double?> AbundanceStudyVariable { get; set; } = new List<double?>();
        
        [JsonPropertyName("abundance_variation_study_variable")]
        public List<double?> AbundanceVariationStudyVariable { get; set; } = new List<double?>();
        
        public List<OptColumnMapping> Opt { get; set; } = new List<OptColumnMapping>();
        
        public List<Comment> Comment { get; set; } = new List<Comment>();
    }

    public class SmallMoleculeFeature
    {
        public Prefix3 Prefix { get; set; } = Prefix3.SMF;
        
        [JsonPropertyName("header_prefix")]
        public HeaderPrefix1 HeaderPrefix { get; set; } = HeaderPrefix1.SFH;
        
        [Required]
        [JsonPropertyName("smf_id")]
        public int SmfId { get; set; }
        
        [JsonPropertyName("sme_id_refs")]
        public List<int> SmeIdRefs { get; set; } = new List<int>();
        
        [JsonPropertyName("sme_id_ref_ambiguity_code")]
        public int? SmeIdRefAmbiguityCode { get; set; }
        
        [JsonPropertyName("adduct_ion")]
        [RegularExpression(@"^\[\d*M([+-][\w\d]+)*\]\d*[+-]$")]
        public string AdductIon { get; set; }
        
        public Parameter Isotopomer { get; set; }
        
        [Required]
        [JsonPropertyName("exp_mass_to_charge")]
        public double ExpMassToCharge { get; set; }
        
        [Required]
        public int Charge { get; set; }
        
        [JsonPropertyName("retention_time_in_seconds")]
        public double? RetentionTimeInSeconds { get; set; }
        
        [JsonPropertyName("retention_time_in_seconds_start")]
        public double? RetentionTimeInSecondsStart { get; set; }
        
        [JsonPropertyName("retention_time_in_seconds_end")]
        public double? RetentionTimeInSecondsEnd { get; set; }
        
        [JsonPropertyName("abundance_assay")]
        public List<double?> AbundanceAssay { get; set; } = new List<double?>();
        
        public List<OptColumnMapping> Opt { get; set; } = new List<OptColumnMapping>();
        
        public List<Comment> Comment { get; set; } = new List<Comment>();
    }

    public class Publication
    {
        [Range(1, int.MaxValue)]
        public int? Id { get; set; }
        
        [Required]
        [JsonPropertyName("publicationItems")]
        public List<PublicationItem> PublicationItems { get; set; }
    }

    public class SpectraRef
    {
        [Required]
        [JsonPropertyName("ms_run")]
        public MsRun MsRun { get; set; }
        
        [Required]
        public string Reference { get; set; }
    }

    public class StudyVariable
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [JsonPropertyName("assay_refs")]
        public List<Assay> AssayRefs { get; set; } = new List<Assay>();
        
        [JsonPropertyName("average_function")]
        public Parameter AverageFunction { get; set; }
        
        [JsonPropertyName("variation_function")]
        public Parameter VariationFunction { get; set; }
        
        public string Description { get; set; }
        
        public List<Parameter> Factors { get; set; } = new List<Parameter>();
    }

    public class Metadata
    {
        [Required]
        public Prefix1 Prefix { get; set; }
        
        [Required]
        [JsonPropertyName("mzTab-version")]
        [RegularExpression(@"^\d{1}\.\d{1}\.\d{1}-[A-Z]{1}$")]
        public string MzTabVersion { get; set; }
        
        [Required]
        [JsonPropertyName("mzTab-ID")]
        public string MzTabID { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public List<Contact> Contact { get; set; } = new List<Contact>();
        
        public List<Publication> Publication { get; set; } = new List<Publication>();
        
        public List<Uri> Uri { get; set; } = new List<Uri>();
        
        [JsonPropertyName("external_study_uri")]
        public List<Uri> ExternalStudyUri { get; set; } = new List<Uri>();
        
        public List<Instrument> Instrument { get; set; } = new List<Instrument>();
        
        [Required]
        [JsonPropertyName("quantification_method")]
        public Parameter QuantificationMethod { get; set; }
        
        public List<Sample> Sample { get; set; } = new List<Sample>();
        
        [JsonPropertyName("sample_processing")]
        public List<SampleProcessing> SampleProcessing { get; set; } = new List<SampleProcessing>();
        
        [Required]
        public List<Software> Software { get; set; }
        
        [JsonPropertyName("derivatization_agent")]
        public List<Parameter> DerivationAgent { get; set; } = new List<Parameter>();
        
        [Required]
        [JsonPropertyName("ms_run")]
        public List<MsRun> MsRun { get; set; }
        
        [Required]
        public List<Assay> Assay { get; set; }
        
        [Required]
        [JsonPropertyName("study_variable")]
        public List<StudyVariable> StudyVariable { get; set; }
        
        public List<Parameter> Custom { get; set; } = new List<Parameter>();
        
        [Required]
        public List<CV> Cv { get; set; }
        
        [Required]
        [JsonPropertyName("small_molecule-quantification_unit")]
        public Parameter SmallMoleculeQuantificationUnit { get; set; }
        
        [Required]
        [JsonPropertyName("small_molecule_feature-quantification_unit")]
        public Parameter SmallMoleculeFeatureQuantificationUnit { get; set; }
        
        [JsonPropertyName("small_molecule-identification_reliability")]
        public Parameter SmallMoleculeIdentificationReliability { get; set; }
        
        [Required]
        public List<Database> Database { get; set; }
        
        [Required]
        [JsonPropertyName("id_confidence_measure")]
        public List<Parameter> IdConfidenceMeasure { get; set; }
        
        [JsonPropertyName("colunit-small_molecule")]
        public List<ColumnParameterMapping> ColunitSmallMolecule { get; set; } = new List<ColumnParameterMapping>();
        
        [JsonPropertyName("colunit-small_molecule_feature")]
        public List<ColumnParameterMapping> ColunitSmallMoleculeFeature { get; set; } = new List<ColumnParameterMapping>();
        
        [JsonPropertyName("colunit-small_molecule_evidence")]
        public List<ColumnParameterMapping> ColunitSmallMoleculeEvidence { get; set; } = new List<ColumnParameterMapping>();
    }

    public class SmallMoleculeEvidence
    {
        public Prefix4 Prefix { get; set; } = Prefix4.SME;
        
        [JsonPropertyName("header_prefix")]
        public HeaderPrefix2 HeaderPrefix { get; set; } = HeaderPrefix2.SEH;
        
        [Required]
        [JsonPropertyName("sme_id")]
        public int SmeId { get; set; }
        
        [Required]
        [JsonPropertyName("evidence_input_id")]
        public string EvidenceInputId { get; set; }
        
        [Required]
        [JsonPropertyName("database_identifier")]
        public string DatabaseIdentifier { get; set; }
        
        [JsonPropertyName("chemical_formula")]
        public string ChemicalFormula { get; set; }
        
        public string Smiles { get; set; }
        
        public string Inchi { get; set; }
        
        [JsonPropertyName("chemical_name")]
        public string ChemicalName { get; set; }
        
        [Url]
        public string Uri { get; set; }
        
        [JsonPropertyName("derivatized_form")]
        public Parameter DerivatizedForm { get; set; }
        
        [JsonPropertyName("adduct_ion")]
        [RegularExpression(@"^\[\d*M([+-][\w\d]+)*\]\d*[+-]$")]
        public string AdductIon { get; set; }
        
        [Required]
        [JsonPropertyName("exp_mass_to_charge")]
        public double ExpMassToCharge { get; set; }
        
        [Required]
        public int Charge { get; set; }
        
        [Required]
        [JsonPropertyName("theoretical_mass_to_charge")]
        public double TheoreticalMassToCharge { get; set; }
        
        [Required]
        [JsonPropertyName("spectra_ref")]
        public List<SpectraRef> SpectraRef { get; set; }
        
        [Required]
        [JsonPropertyName("identification_method")]
        public Parameter IdentificationMethod { get; set; }
        
        [Required]
        [JsonPropertyName("ms_level")]
        public Parameter MsLevel { get; set; }
        
        [JsonPropertyName("id_confidence_measure")]
        public List<double?> IdConfidenceMeasure { get; set; } = new List<double?>();
        
        [Required]
        [Range(1, int.MaxValue)]
        public int Rank { get; set; }
        
        public List<OptColumnMapping> Opt { get; set; } = new List<OptColumnMapping>();
        
        public List<Comment> Comment { get; set; } = new List<Comment>();
    }

    public class MzTab
    {
        [Required]
        public Metadata Metadata { get; set; }
        
        [Required]
        [MinLength(1)]
        [JsonPropertyName("smallMoleculeSummary")]
        public List<SmallMoleculeSummary> SmallMoleculeSummary { get; set; }
        
        [Required]
        [JsonPropertyName("smallMoleculeFeature")]
        public List<SmallMoleculeFeature> SmallMoleculeFeature { get; set; }
        
        [Required]
        [JsonPropertyName("smallMoleculeEvidence")]
        public List<SmallMoleculeEvidence> SmallMoleculeEvidence { get; set; }
        
        public List<Comment> Comment { get; set; } = new List<Comment>();
        
        // JSON Serialization Methods
        public string ToJson(JsonSerializerOptions options = null)
        {
            options ??= GetDefaultJsonOptions();
            return JsonSerializer.Serialize(this, options);
        }
        
        public static MzTab FromJson(string json, JsonSerializerOptions options = null)
        {
            options ??= GetDefaultJsonOptions();
            return JsonSerializer.Deserialize<MzTab>(json, options);
        }
        
        private static JsonSerializerOptions GetDefaultJsonOptions()
        {
            return new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters = { new JsonStringEnumConverter() }
            };
        }
    }
    
    // Extension methods for JSON serialization that can be used by all model classes
    public static class JsonSerializationExtensions
    {
        private static readonly JsonSerializerOptions DefaultOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters = { new JsonStringEnumConverter() }
        };
        
        public static string ToJson<T>(this T obj, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Serialize(obj, options ?? DefaultOptions);
        }
        
        public static T FromJson<T>(this string json, JsonSerializerOptions options = null) where T : class
        {
            return JsonSerializer.Deserialize<T>(json, options ?? DefaultOptions);
        }
    }
}