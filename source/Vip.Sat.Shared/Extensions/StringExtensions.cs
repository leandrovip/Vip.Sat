using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Vip.Sat.Exceptions;

namespace Vip.Sat.Extensions
{
    internal static class StringExtensions
    {
        /// <summary>
        ///     Verifica se a string é nula ou vazia
        /// </summary>
        /// <param name="value">string para verificar</param>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        ///     Verifica se a string NÃO é nula ou vazia
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty(this string value)
        {
            return !value.IsNullOrEmpty();
        }

        /// <summary>
        ///     Verifica se a string é numerica.
        /// </summary>
        /// <param name="strNum">The string number.</param>
        /// <returns>Retorna true/false se a string é numerica</returns>
        /// <exception cref="System.Exception">Erro ao validar string</exception>
        /// <exception cref="Exception">Erro ao validar string</exception>
        public static bool IsNumeric(this string strNum)
        {
            try
            {
                var reNum = new Regex(@"^\d+$");
                return reNum.IsMatch(strNum);
            }
            catch (Exception ex)
            {
                throw new VipException("Erro ao validar string", ex);
            }
        }

        /// <summary>
        ///     Retorna apenas os numeros da string.
        /// </summary>
        /// <param name="value">String para processar.</param>
        /// <returns>System.String.</returns>
        public static string OnlyNumbers(this string value)
        {
            return value.Trim().IsNullOrEmpty()
                ? string.Empty
                : new string(value.Where(char.IsDigit).ToArray());
        }

        /// <summary>
        ///     Betweens the specified start.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns>System.String.</returns>
        public static string GetStrBetween(this string value, int start, int end)
        {
            if (value.IsNullOrEmpty()) return string.Empty;

            var len = value.Length;

            if (start < 0) start += len;

            if (end < 0) end += len;

            if (len == 0 || start > len - 1 || end < start) return string.Empty;

            if (start < 0) start = 0;

            if (end >= len) end = len - 1;

            return value.Substring(start, end - start + 1);
        }

        /// <summary>
        ///     Preenche uma string com zero a direita ate ficar do tamanho especificado.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="length">Tamanho final desejado</param>
        /// <returns>String do tamanho especificado e se menor complementada com zero a direita/esquerda</returns>
        public static string ZeroFill(this string text, int length)
        {
            return text.OnlyNumbers().StringFill(length, '0');
        }

        /// <summary>
        ///     Alinha a string a direita/esquerda e preenche com caractere informado ate ficar do tamanho especificado.
        /// </summary>
        /// <param name="text">O texto</param>
        /// <param name="length">Tamanho final desejado</param>
        /// <param name="with">Caractere para preencher</param>
        /// <param name="esquerda">Direção do preenchimento</param>
        /// <returns>String do tamanho especificado e se menor complementada com o caractere informado a direita/esquerda</returns>
        public static string StringFill(this string text, int length, char with = ' ', bool esquerda = true)
        {
            if (text.IsNullOrEmpty()) text = string.Empty;

            if (text.Length > length)
            {
                text = text.Remove(length);
            }
            else
            {
                length -= text.Length;

                if (esquerda)
                    text = new string(with, length) + text;
                else
                    text += new string(with, length);
            }

            return text;
        }

        /// <summary>
        ///     Remove acentos da string
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string RemoveAccent(this string texto)
        {
            if (texto.IsNullOrEmpty())
                return string.Empty;

            const string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç&º°ª";
            const string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCcE   ";

            for (var i = 0; i < comAcentos.Length; i++)
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());

            return texto;
        }

        /// <summary>
        ///     To the int32.
        /// </summary>
        /// <param name="dados">The dados.</param>
        /// <param name="def">The definition.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="VipException">Erro ao converter string</exception>
        /// <exception cref="VipException">Erro ao converter string</exception>
        public static int ToInt32(this string dados, int def = -1)
        {
            return ToInt32(dados, def, CultureInfo.CurrentCulture);
        }

        /// <summary>
        ///     To the int32.
        /// </summary>
        /// <param name="dados">The dados.</param>
        /// <param name="format">The format.</param>
        /// <returns>System.Int32.</returns>
        public static int ToInt32(this string dados, IFormatProvider format)
        {
            return ToInt32(dados, -1, format);
        }

        /// <summary>
        ///     To the int32.
        /// </summary>
        /// <param name="dados">The dados.</param>
        /// <param name="def">The definition.</param>
        /// <param name="format">The format.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="VipException">Erro ao converter string</exception>
        public static int ToInt32(this string dados, int def, IFormatProvider format)
        {
            try
            {
                if (!int.TryParse(dados, NumberStyles.Any, format, out var converted))
                    converted = def;

                return converted;
            }
            catch (Exception ex)
            {
                throw new VipException("Erro ao converter string", ex);
            }
        }

        /// <summary>
        ///     To the int64.
        /// </summary>
        /// <param name="dados">The dados.</param>
        /// <param name="def">The definition.</param>
        /// <returns>System.Int64.</returns>
        public static long ToInt64(this string dados, long def = -1)
        {
            return ToInt64(dados, def, CultureInfo.CurrentCulture);
        }

        /// <summary>
        ///     To the int64.
        /// </summary>
        /// <param name="dados">The dados.</param>
        /// <param name="format">The format.</param>
        /// <returns>System.Int64.</returns>
        public static long ToInt64(this string dados, IFormatProvider format)
        {
            return ToInt64(dados, -1, format);
        }

        /// <summary>
        ///     To the int64.
        /// </summary>
        /// <param name="dados">The dados.</param>
        /// <param name="def">The definition.</param>
        /// <param name="format">The format.</param>
        /// <returns>Int64.</returns>
        /// <exception cref="VipException">Erro ao converter string</exception>
        /// <exception cref="VipException">Erro ao converter string</exception>
        public static long ToInt64(this string dados, long def, IFormatProvider format)
        {
            try
            {
                if (!long.TryParse(dados, NumberStyles.Any, format, out var converted))
                    converted = def;

                return converted;
            }
            catch (Exception ex)
            {
                throw new VipException("Erro ao converter string", ex);
            }
        }

        /// <summary>
        ///     To the data.
        /// </summary>
        /// <param name="dados">The dados.</param>
        /// <returns>DateTime.</returns>
        /// <exception cref="VipException">Erro ao converter string</exception>
        /// <exception cref="VipException">Erro ao converter string</exception>
        public static DateTime ToData(this string dados)
        {
            try
            {
                if (!DateTime.TryParse(dados, out var converted))
                    converted = default;

                return converted;
            }
            catch (Exception ex)
            {
                throw new VipException("Erro ao converter string", ex);
            }
        }

        /// <summary>
        ///     To the data.
        /// </summary>
        /// <param name="dados">The dados.</param>
        /// <returns>DateTime.</returns>
        /// <exception cref="VipException">Erro ao converter string</exception>
        /// <exception cref="VipException">Erro ao converter string</exception>
        public static DateTimeOffset ToDataOffset(this string dados)
        {
            try
            {
                if (!DateTimeOffset.TryParse(dados, out var converted))
                    converted = default;

                return converted;
            }
            catch (Exception ex)
            {
                throw new VipException("Erro ao converter string", ex);
            }
        }
    }
}