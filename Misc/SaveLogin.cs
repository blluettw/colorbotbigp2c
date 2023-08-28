using Microsoft.Win32;

namespace Utorrent.Misc
{
    class SaveLogin
    {

        private string caminho = "SOFTWARE\\FGAim";

        public void Salvar(string user, string senha)
        {
            try
            {
                RegistryKey chave = Registry.CurrentUser.OpenSubKey(caminho);

                if (chave == null)
                {
                    RegistryKey chave2 = Registry.CurrentUser.CreateSubKey(caminho);
                    chave2.SetValue("senha", senha);
                    chave2.SetValue("user", user);
                    chave2.Close();
                    return;
                }
                else
                {
                    chave.SetValue("senha", senha);
                    chave.SetValue("user", user);
                    chave.Close();
                    return;
                }
            }
            catch
            {
                return;
            }
        }



        public void Deletar()
        {

            RegistryKey chave = Registry.CurrentUser.OpenSubKey(caminho);

            if (chave == null)
            {
                return;
            }
            else
            {
                try
                {
                    Registry.CurrentUser.DeleteSubKey(caminho);
                    return;
                }
                catch { return; }
            }

        }

    }
}
