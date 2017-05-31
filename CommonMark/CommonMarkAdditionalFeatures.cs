using System;

namespace CommonMark
{
    /// <summary>
    /// Lists additional features that can be enabled in <see cref="CommonMarkSettings"/>.
    /// These features are not part of the standard and should not be used if interoperability with other
    /// CommonMark implementations is required.
    /// </summary>
    [Flags]
    public enum CommonMarkAdditionalFeatures
    {
        /// <summary>
        /// No additional features are enabled. This is the default.
        /// </summary>
        None = 0,

        /// <summary>
        /// The parser will recognize syntax <c>~~foo~~</c> that will be rendered as <c>&lt;del&gt;foo&lt;/del&gt;</c>.
        /// </summary>
        StrikethroughTilde = 1,

        /// <summary>
        /// The parser will recognize syntax <c>[foo]</c>, which will be encoded in a separate AST node that the host application may evaluate as desired.
        /// </summary>
        PlaceholderBracket = 2,

        /// <summary>
        /// The parser will recognize
        /// <code>
        /// First Header  | Second Header
        /// ------------- | -------------
        /// Content Cell  | Content Cell
        /// Content Cell  | Content Cell
        /// </code>
        /// style tables.
        ///
        /// Refer to https://github.github.com/gfm/#tables-extension- for more examples
        /// </summary>
        GithubStyleTables = 4,

        /// <summary>
        /// The parser will recognize
        /// <code>
        /// - [ ] First list item
        /// - [x] Checked list item
        /// </code>
        /// as TaskList.
        ///
        /// Refer to https://github.github.com/gfm/#task-list-items-extension- for more examples
        /// </summary>
        GitHubStyleTaskList = 8,

        /// <summary>
        /// All additional features are enabled.
        /// </summary>
        All = 0x7FFFFFFF
    }
}
