using System.IO;
using System.Text;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Common;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.DFeCore.Document
{
    /// <summary>
    ///     Class DFeDocument.
    /// </summary>
    /// <typeparam name="TDocument">The type of the t document.</typeparam>
    /// <seealso cref="GenericClone{T}" />
    public abstract class DFeDocument<TDocument> : GenericClone<TDocument> where TDocument : class
    {
        #region Properties

        [DFeIgnore] public string Xml { get; protected set; }

        #endregion Properties

        #region Methods

        /// <summary>
        ///     Carrega o documento.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>TDocument.</returns>
        public static TDocument Load(string document, Encoding encoding = null)
        {
            var serializer = new DFeSerializer<TDocument>();
            if (encoding != null) serializer.Options.Encoding = encoding;

            var content = File.Exists(document) ? File.ReadAllText(document, serializer.Options.Encoding) : document;
            var ret = serializer.Deserialize(document);
            (ret as DFeDocument<TDocument>).Xml = content;
            return ret;
        }

        /// <summary>
        ///     Carrega o documento.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="encoding"></param>
        /// <returns>TDocument.</returns>
        public static TDocument Load(Stream document, Encoding encoding = null)
        {
            var serializer = new DFeSerializer<TDocument>();
            if (encoding != null) serializer.Options.Encoding = encoding;

            using (var reader = new StreamReader(document, serializer.Options.Encoding))
            {
                document.Position = 0;

                var content = reader.ReadToEnd();
                var ret = serializer.Deserialize(content);
                (ret as DFeDocument<TDocument>).Xml = content;
                return ret;
            }
        }

        /// <summary>
        ///     Retorna o Xml do documento.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>System.String.</returns>
        public virtual string GetXml(DFeSaveOptions options = DFeSaveOptions.DisableFormatting, Encoding encoding = null)
        {
            using (var stream = new MemoryStream())
            {
                Save(stream, options, encoding);
                using (var streamReader = new StreamReader(stream)) return streamReader.ReadToEnd();
            }
        }

        /// <summary>
        ///     Salva o documento.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="options">The options.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>TDocument.</returns>
        public virtual void Save(string path, DFeSaveOptions options = DFeSaveOptions.DisableFormatting, Encoding encoding = null)
        {
            var serializer = new DFeSerializer<TDocument>();

            if (!options.HasFlag(DFeSaveOptions.None))
            {
                serializer.Options.RemoverAcentos = options.HasFlag(DFeSaveOptions.RemoveAccents);
                serializer.Options.RemoverEspacos = options.HasFlag(DFeSaveOptions.RemoveSpaces);
                serializer.Options.FormatarXml = !options.HasFlag(DFeSaveOptions.DisableFormatting);
                serializer.Options.OmitirDeclaracao = options.HasFlag(DFeSaveOptions.OmitDeclaration);
            }

            if (encoding != null) serializer.Options.Encoding = encoding;

            serializer.Serialize(this, path);
            Xml = File.ReadAllText(path, serializer.Options.Encoding);
        }

        /// <summary>
        ///     Salva o documento.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="options">The options.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>TDocument.</returns>
        public virtual void Save(Stream stream, DFeSaveOptions options = DFeSaveOptions.DisableFormatting, Encoding encoding = null)
        {
            var serializer = new DFeSerializer<TDocument>();

            if (!options.HasFlag(DFeSaveOptions.None))
            {
                serializer.Options.RemoverAcentos = options.HasFlag(DFeSaveOptions.RemoveAccents);
                serializer.Options.RemoverEspacos = options.HasFlag(DFeSaveOptions.RemoveSpaces);
                serializer.Options.FormatarXml = !options.HasFlag(DFeSaveOptions.DisableFormatting);
                serializer.Options.OmitirDeclaracao = options.HasFlag(DFeSaveOptions.OmitDeclaration);
            }

            if (encoding != null) serializer.Options.Encoding = encoding;

            serializer.Serialize(this, stream);

            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                stream.Position = 0;
                using (var reader = new StreamReader(ms, serializer.Options.Encoding)) Xml = reader.ReadToEnd();
            }
        }

        #endregion Methods
    }
}