using System.Threading.Tasks;

namespace Nop.Web.Framework.UI
{
    /// <summary>
    /// Page head builder
    /// </summary>
    public partial interface IPageHeadBuilder
    {
        /// <summary>
        /// Add title element to the <![CDATA[<head>]]>
        /// </summary>
        /// <param name="part">Title part</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task AddTitlePartsAsync(string part);

        /// <summary>
        /// Append title element to the <![CDATA[<head>]]>
        /// </summary>
        /// <param name="part">Title part</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task AppendTitlePartsAsync(string part);

        /// <summary>
        /// Generate all title parts
        /// </summary>
        /// <param name="addDefaultTitle">A value indicating whether to insert a default title</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the generated string
        /// </returns>
        Task<string> GenerateTitleAsync(bool addDefaultTitle);

        /// <summary>
        /// Add meta description element to the <![CDATA[<head>]]>
        /// </summary>
        /// <param name="part">Meta description part</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task AddMetaDescriptionPartsAsync(string part);

        /// <summary>
        /// Append meta description element to the <![CDATA[<head>]]>
        /// </summary>
        /// <param name="part">Meta description part</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task AppendMetaDescriptionPartsAsync(string part);

        /// <summary>
        /// Generate all description parts
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the generated string
        /// </returns>
        Task<string> GenerateMetaDescriptionAsync();

        /// <summary>
        /// Add meta keyword element to the <![CDATA[<head>]]>
        /// </summary>
        /// <param name="part">Meta keyword part</param>
        /// <returns>A task that represents the asynchronous operation</returns> 
        Task AddMetaKeywordPartsAsync(string part);

        /// <summary>
        /// Append meta keyword element to the <![CDATA[<head>]]>
        /// </summary>
        /// <param name="part">Meta keyword part</param>
        /// <returns>A task that represents the asynchronous operation</returns>  
        Task AppendMetaKeywordPartsAsync(string part);

        /// <summary>
        /// Generate all keyword parts
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the generated string
        /// </returns>
        Task<string> GenerateMetaKeywordsAsync();

        /// <summary>
        /// Add script element
        /// </summary>
        /// <param name="location">A location of the script element</param>
        /// <param name="src">Script path (minified version)</param>
        /// <param name="debugSrc">Script path (full debug version). If empty, then minified version will be used</param>
        /// <param name="excludeFromBundle">A value indicating whether to exclude this script from bundling</param>
        /// <param name="isAsync">A value indicating whether to add an attribute "async" or not for js files</param>
        /// <returns>A task that represents the asynchronous operation</returns> 
        Task AddScriptPartsAsync(ResourceLocation location, string src, string debugSrc, bool excludeFromBundle, bool isAsync);

        /// <summary>
        /// Append script element
        /// </summary>
        /// <param name="location">A location of the script element</param>
        /// <param name="src">Script path (minified version)</param>
        /// <param name="debugSrc">Script path (full debug version). If empty, then minified version will be used</param>
        /// <param name="excludeFromBundle">A value indicating whether to exclude this script from bundling</param>
        /// <param name="isAsync">A value indicating whether to add an attribute "async" or not for js files</param>
        /// <returns>A task that represents the asynchronous operation</returns>  
        Task AppendScriptPartsAsync(ResourceLocation location, string src, string debugSrc, bool excludeFromBundle, bool isAsync);

        /// <summary>
        /// Generate all script parts
        /// </summary>
        /// <param name="location">A location of the script element</param>
        /// <param name="bundleFiles">A value indicating whether to bundle script elements</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the generated string
        /// </returns>
        Task<string> GenerateScriptsAsync(ResourceLocation location, bool? bundleFiles = null);

        /// <summary>
        /// Add inline script element
        /// </summary>
        /// <param name="location">A location of the script element</param>
        /// <param name="script">Script</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task AddInlineScriptPartsAsync(ResourceLocation location, string script);

        /// <summary>
        /// Append inline script element
        /// </summary>
        /// <param name="location">A location of the script element</param>
        /// <param name="script">Script</param>
        /// <returns>A task that represents the asynchronous operation</returns> 
        Task AppendInlineScriptPartsAsync(ResourceLocation location, string script);

        /// <summary>
        /// Generate all inline script parts
        /// </summary>
        /// <param name="location">A location of the script element</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the generated string
        /// </returns>
        Task<string> GenerateInlineScriptsAsync(ResourceLocation location);

        /// <summary>
        /// Add CSS element
        /// </summary>
        /// <param name="location">A location of the script element</param>
        /// <param name="src">Script path (minified version)</param>
        /// <param name="debugSrc">Script path (full debug version). If empty, then minified version will be used</param>
        /// <param name="excludeFromBundle">A value indicating whether to exclude this script from bundling</param>
        /// <returns>A task that represents the asynchronous operation</returns> 
        Task AddCssFilePartsAsync(ResourceLocation location, string src, string debugSrc, bool excludeFromBundle = false);

        /// <summary>
        /// Append CSS element
        /// </summary>
        /// <param name="location">A location of the script element</param>
        /// <param name="src">Script path (minified version)</param>
        /// <param name="debugSrc">Script path (full debug version). If empty, then minified version will be used</param>
        /// <param name="excludeFromBundle">A value indicating whether to exclude this script from bundling</param>
        /// <returns>A task that represents the asynchronous operation</returns> 
        Task AppendCssFilePartsAsync(ResourceLocation location, string src, string debugSrc, bool excludeFromBundle = false);

        /// <summary>
        /// Generate all CSS parts
        /// </summary>
        /// <param name="location">A location of the script element</param>
        /// <param name="bundleFiles">A value indicating whether to bundle script elements</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the generated string
        /// </returns>
        Task<string> GenerateCssFilesAsync(ResourceLocation location, bool? bundleFiles = null);

        /// <summary>
        /// Add canonical URL element to the <![CDATA[<head>]]>
        /// </summary>
        /// <param name="part">Canonical URL part</param>
        /// <returns>A task that represents the asynchronous operation</returns> 
        Task AddCanonicalUrlPartsAsync(string part);

        /// <summary>
        /// Append canonical URL element to the <![CDATA[<head>]]>
        /// </summary>
        /// <param name="part">Canonical URL part</param>
        /// <returns>A task that represents the asynchronous operation</returns> 
        Task AppendCanonicalUrlPartsAsync(string part);

        /// <summary>
        /// Generate all canonical URL parts
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the generated string
        /// </returns>
        Task<string> GenerateCanonicalUrlsAsync();

        /// <summary>
        /// Add any custom element to the <![CDATA[<head>]]> element
        /// </summary>
        /// <param name="part">The entire element. For example, <![CDATA[<meta name="msvalidate.01" content="123121231231313123123" />]]></param>
        /// <returns>A task that represents the asynchronous operation</returns>  
        Task AddHeadCustomPartsAsync(string part);

        /// <summary>
        /// Append any custom element to the <![CDATA[<head>]]> element
        /// </summary>
        /// <param name="part">The entire element. For example, <![CDATA[<meta name="msvalidate.01" content="123121231231313123123" />]]></param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task AppendHeadCustomPartsAsync(string part);

        /// <summary>
        /// Generate all custom elements
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the generated string
        /// </returns>
        Task<string> GenerateHeadCustomAsync();

        /// <summary>
        /// Add CSS class to the <![CDATA[<head>]]> element
        /// </summary>
        /// <param name="part">CSS class</param>
        /// <returns>A task that represents the asynchronous operation</returns> 
        Task AddPageCssClassPartsAsync(string part);

        /// <summary>
        /// Append CSS class to the <![CDATA[<head>]]> element
        /// </summary>
        /// <param name="part">CSS class</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task AppendPageCssClassPartsAsync(string part);

        /// <summary>
        /// Generate all title parts
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the generated string
        /// </returns>
        Task<string> GeneratePageCssClassesAsync();

        /// <summary>
        /// Specify "edit page" URL
        /// </summary>
        /// <param name="url">URL</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task AddEditPageUrlAsync(string url);

        /// <summary>
        /// Get "edit page" URL
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the url
        /// </returns>
        Task<string> GetEditPageUrlAsync();

        /// <summary>
        /// Specify system name of admin menu item that should be selected (expanded)
        /// </summary>
        /// <param name="systemName">System name</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task SetActiveMenuItemSystemNameAsync(string systemName);

        /// <summary>
        /// Get system name of admin menu item that should be selected (expanded)
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the system name
        /// </returns>
        Task<string> GetActiveMenuItemSystemNameAsync();
    }
}
