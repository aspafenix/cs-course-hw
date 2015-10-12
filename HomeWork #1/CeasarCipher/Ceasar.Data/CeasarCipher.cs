using System;

namespace Ceasar.Data
{
    public class CeasarCipher
    {
        private readonly int offset;

        private readonly int MinValue = 32; // defines the 'space' symbol
        private readonly int MaxValue = 126; // defines the '~' symbol

        public CeasarCipher(int offset)
        {
            this.offset = offset;
        }

        public string Encrypt(string text)
        {
            
            if ((text != null))
            {
                char[] symbols = text.ToCharArray();

                for (int i = 0; i < symbols.Length; i++)
                {
                    if (symbols[i] >= MinValue && symbols[i] <= MaxValue)
                    {
                        if (symbols[i] != 32)
                        {
                            if (!((symbols[i] + offset) >= MaxValue))
                            {
                                symbols[i] = (char) (symbols[i] + offset);
                            }
                            else
                            {
                                symbols[i] = (char) (symbols[i] + offset - MaxValue + MinValue);
                            }

                        }
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(text);
                    }

                }
                text = new string(symbols);
            }
            else
            {
                throw new ArgumentNullException("text");
            }

            return text;
        }

        public string Decrypt(string text)
        {
            if (text != null)
            {
                char[] symbols = text.ToCharArray();

                for (int i = 0; i < symbols.Length; i++)
                {
                    if (symbols[i] >= MinValue && symbols[i] <= MaxValue)
                    {
                        if (symbols[i] != MinValue)
                        {
                            if (!((symbols[i] - offset) <= MinValue))
                            {
                                symbols[i] = (char) (symbols[i] - offset);
                            }
                            else
                            {
                                symbols[i] = (char) (symbols[i] - offset - MinValue + MaxValue);
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(text);
                    }
                }
                text = new string(symbols);
            }

            else
            {
                throw new ArgumentNullException("text");
            }

            return text;
        }  
    }
}
