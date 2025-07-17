using System.Collections.Generic;
using System.Drawing;

namespace pulp_stone_ai_test_gui
{
    internal class Errors
    {
        public static readonly Dictionary<string, string> StatusErrors =
            new Dictionary<string, string>
            {
                    { "image_count_zero", "Lütfen en az bir resim seçin" },
                    { "model_not_selected", "Lütfen bir model seçin" }
            };
    }
}
