using Master.Actions;
using static Master.Actions.Ax;

namespace Master.Utilities
{
    internal static class Remaper
    {
        public static bool MasterWinAction => biblioteca.MasterWinAction;

        public static bool HandleMouse(int button, bool isDown)
        {
            if (!MasterWinAction)
                return true;

            // botão direito
            if (button == 2)
            {
                if (isDown)
                    LanzarTeclaDown(KeyN.A);

                if (!isDown)
                    LanzarTeclaUp();

                return false; // bloqueia original
            }

            return true;
        }
    }
}
