    internal string DebugDisplayString
        {
            get // good
            {
                return string.Concat(
                    this.X.ToString(), "  ",
                    this.Y.ToString()
                );
            }
        }
            public struct TextInputEventArgs
    {
        public TextInputEventArgs(char character, Keys key = Keys.None)
        {
            Character = character;
            Key = key;
        }
                  public Vector4(Vector2 value, float z, float w)
        {
            this.X = value.X;
            this.Y = value.Y;
            this.Z = z;
            this.W = w;
        }
     public Vector4(Vector3 value, float w)
        {
            this.X = value.X;
            this.Y = value.Y;
            this.Z = value.Z;
            this.W = w;
        }
