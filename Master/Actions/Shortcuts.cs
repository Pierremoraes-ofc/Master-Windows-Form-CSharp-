using static Master.Actions.Ax;

namespace Master.Actions
{
    internal static partial class Ax
    {
        //  Exemplo de uso: Ax.WindowsShortcuts.Copiar();
        internal static class WindowsShortcuts
        {
            // ===============================
            // 📋 CLIPBOARD
            // ===============================

            /// <summary>
            /// Copia o item selecionado para o clipboard (CTRL + C)
            /// </summary>
            internal static void Copiar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.C);
            }

            /// <summary>
            /// Cola o conteúdo do clipboard (CTRL + V)
            /// </summary>
            internal static void Colar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.V);
            }

            /// <summary>
            /// Recorta o item selecionado (CTRL + X)
            /// </summary>
            internal static void Recortar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.X);
            }

            /// <summary>
            /// Seleciona tudo (CTRL + A)
            /// </summary>
            internal static void SelecionarTudo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.A);
            }

            /// <summary>
            /// Desfaz última ação (CTRL + Z)
            /// </summary>
            internal static void Desfazer()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.Z);
            }

            /// <summary>
            /// Refaz última ação (CTRL + Y)
            /// </summary>
            internal static void Refazer()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.Y);
            }

            // ===============================
            // 📁 FILE EXPLORER
            // ===============================

            /// <summary>
            /// Cria nova pasta (CTRL + SHIFT + N)
            /// </summary>
            internal static void NovaPasta()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.N);
            }

            /// <summary>
            /// Abre o item selecionado (ENTER)
            /// </summary>
            internal static void Abrir()
            {
                LanzarTecla(KeyN.RETURN);
            }

            /// <summary>
            /// Renomeia item selecionado (F2)
            /// </summary>
            internal static void Renomear()
            {
                LanzarTecla(KeyN.F2);
            }

            /// <summary>
            /// Deleta item selecionado (DELETE)
            /// </summary>
            internal static void Deletar()
            {
                LanzarTecla(KeyN.DELETE);
            }

            /// <summary>
            /// Deleta permanentemente (SHIFT + DELETE)
            /// </summary>
            internal static void DeletarPermanentemente()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.DELETE);
            }

            /// <summary>
            /// Atualiza janela (F5)
            /// </summary>
            internal static void Atualizar()
            {
                LanzarTecla(KeyN.F5);
            }

            // ===============================
            // 🪟 WINDOWS SYSTEM
            // ===============================

            /// <summary>
            /// Abre o menu iniciar (WIN)
            /// </summary>
            internal static void MenuIniciar()
            {
                LanzarTecla(KeyN.WIN_L);
            }

            /// <summary>
            /// Abre Explorer (WIN + E)
            /// </summary>
            internal static void AbrirExplorer()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.E);
            }

            /// <summary>
            /// Abre configurações (WIN + I)
            /// </summary>
            internal static void Configuracoes()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.I);
            }

            /// <summary>
            /// Abre Executar (WIN + R)
            /// </summary>
            internal static void Executar()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.R);
            }

            /// <summary>
            /// Bloqueia o computador (WIN + L)
            /// </summary>
            internal static void BloquearPC()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.L);
            }

            /// <summary>
            /// Mostra desktop (WIN + D)
            /// </summary>
            internal static void MostrarDesktop()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.D);
            }

            /// <summary>
            /// Minimiza todas as janelas (WIN + M)
            /// </summary>
            internal static void MinimizarTudo()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.M);
            }

            /// <summary>
            /// Restaura todas as janelas (WIN + SHIFT + M)
            /// </summary>
            internal static void RestaurarJanelas()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.SHIFT, KeyN.M);
            }

            // ===============================
            // 🪟 WINDOW MANAGEMENT
            // ===============================

            /// <summary>
            /// Alterna entre janelas (ALT + TAB)
            /// </summary>
            internal static void AlternarJanela()
            {
                LanzarCombo(KeyN.MENU, KeyN.TAB);
            }

            /// <summary>
            /// Fecha janela atual (ALT + F4)
            /// </summary>
            internal static void FecharJanela()
            {
                LanzarCombo(KeyN.MENU, KeyN.F4);
            }

            /// <summary>
            /// Maximiza janela (WIN + UP)
            /// </summary>
            internal static void MaximizarJanela()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.UP);
            }

            /// <summary>
            /// Minimiza janela (WIN + DOWN)
            /// </summary>
            internal static void MinimizarJanela()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.DOWN);
            }

            /// <summary>
            /// Move janela para esquerda (WIN + LEFT)
            /// </summary>
            internal static void FixarEsquerda()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.LEFT);
            }

            /// <summary>
            /// Move janela para direita (WIN + RIGHT)
            /// </summary>
            internal static void FixarDireita()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.RIGHT);
            }

            // ===============================
            // 🧠 SYSTEM TOOLS
            // ===============================

            /// <summary>
            /// Abre gerenciador de tarefas (CTRL + SHIFT + ESC)
            /// </summary>
            internal static void TaskManager()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.ESCAPE);
            }

            /// <summary>
            /// Abre menu avançado Windows (WIN + X)
            /// </summary>
            internal static void MenuAvancadoWindows()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.X);
            }

            /// <summary>
            /// Abre pesquisa Windows (WIN + S)
            /// </summary>
            internal static void PesquisaWindows()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.S);
            }

            // ===============================
            // 📸 SCREENSHOTS
            // ===============================

            /// <summary>
            /// Screenshot da tela inteira (PRINT SCREEN)
            /// </summary>
            internal static void PrintScreen()
            {
                LanzarTecla(KeyN.SNAPSHOT);
            }

            /// <summary>
            /// Screenshot com ferramenta Windows (WIN + SHIFT + S)
            /// </summary>
            internal static void ScreenshotTool()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.SHIFT, KeyN.S);
            }

            // ===============================
            // 📑 VIRTUAL DESKTOPS
            // ===============================

            /// <summary>
            /// Novo desktop virtual (WIN + CTRL + D)
            /// </summary>
            internal static void NovoDesktopVirtual()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.CONTROL, KeyN.D);
            }

            /// <summary>
            /// Fecha desktop virtual (WIN + CTRL + F4)
            /// </summary>
            internal static void FecharDesktopVirtual()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.CONTROL, KeyN.F4);
            }

            /// <summary>
            /// Próximo desktop virtual (WIN + CTRL + RIGHT)
            /// </summary>
            internal static void ProximoDesktopVirtual()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.CONTROL, KeyN.RIGHT);
            }

            /// <summary>
            /// Desktop virtual anterior (WIN + CTRL + LEFT)
            /// </summary>
            internal static void DesktopVirtualAnterior()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.CONTROL, KeyN.LEFT);
            }

            /// Abre lupa (WIN + PLUS)
            internal static void AbrirLupa()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.OEM_PLUS);
            }

            /// Minimiza janela atual (ALT + SPACE, N)
            internal static void Minimizajanelaatual()
            {
                LanzarCombo(KeyN.MENU, KeyN.SPACE);
            }

            /// Menu contexto (SHIFT + F10)
            internal static void Menucontexto()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F10);
            }

            /// Propriedades (ALT + ENTER)
            internal static void Propriedades()
            {
                LanzarCombo(KeyN.MENU, KeyN.RETURN);
            }
            /// Move janela para outro monitor (WIN + SHIFT + LEFT)
            internal static void MovejanelaparaMonitorEsquerdo()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.SHIFT, KeyN.LEFT);
            }

            /// Move janela para outro monitor (WIN + SHIFT + RIGHT)
            internal static void MovejanelaparaMonitorDireito()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.SHIFT, KeyN.RIGHT);
            }

            /// Abre segurança Windows (CTRL + ALT + DELETE)
            internal static void GerenciadordeTarefas()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.DELETE);
            }

            /// Executa como administrador (CTRL + SHIFT + ENTER)
            internal static void ExecutacomoAdministrador()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.RETURN);
            }

            /// Abre Game Bar (WIN + G)
            internal static void AbreGameBar()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.G);
            }

            /// Nova janela explorer (CTRL + N)
            internal static void NovajanelaNavegador()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.N);
            }

            /// Nova aba explorer (CTRL + T)
            internal static void NovaabaNavegador()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.T);
            }

            /// Fecha aba explorer (CTRL + W)
            internal static void FechaabaNavegador()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.W);
            }

            /// Atualização completa (CTRL + F5)
            internal static void AtualizarPagina()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F5);
            }

            /// Abre pesquisa (WIN + Q)
            internal static void Abrepesquisa()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.Q);
            }

            /// Abre notificações (WIN + A)
            internal static void Abrenotificações()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.A);
            }

            /// Abre configurações rápidas (WIN + B)
            internal static void Abreconfigurações()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.B);
            }

            /// Abre widget (WIN + W)
            internal static void Abrewidget()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.W);
            }

            /// Abre histórico clipboard (WIN + V)
            internal static void Abrehistóricoclipboard()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.V);
            }

            /// Abre painel emoji (WIN + .)
            internal static void Abrepainelemoji()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.OEM_PERIOD);
            }

            /// Alternar apps direto (WIN + TAB)
            internal static void Alternarappsdireto()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.TAB);
            }

            /// Minimizar tudo exceto janela atual (WIN + HOME)
            internal static void Minimizartudoexcetojanelaatual()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.HOME);
            }

            /// Maximizar verticalmente (WIN + SHIFT + UP)
            internal static void Maximizarverticalmente()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.SHIFT, KeyN.UP);
            }

            /// Restaurar verticalmente (WIN + SHIFT + DOWN)
            internal static void Restaurarverticalmente()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.SHIFT, KeyN.DOWN);
            }

            /// Foca na barra de tarefas (WIN + T)
            internal static void Focanabarradetarefas()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.T);
            }

            /// Abre primeiro app da barra (WIN + 1)
            internal static void Abreprimeiroappdabarra()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.NUM_1);
            }

            /// Abre segundo app da barra (WIN + 2)
            internal static void Abresegundoappdabarra()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.NUM_2);
            }

            /// Percorre apps abertos (WIN + T)
            internal static void Percorreappsabertos()
            {
                LanzarCombo(KeyN.WIN_L, KeyN.T);
            }
        }

        //  Exemplo de uso: Ax.ExcelShortcuts.Copiar();
        internal static class ExcelShortcuts
        {
            /// Fechar arquivo (CTRL + W)
            internal static void FecharArquivo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.W);
            }

            // ===============================
            // ✏️ EDIÇÃO
            // ===============================

            /// Copiar (CTRL + C)
            internal static void Copiar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.C);
            }

            /// Colar (CTRL + V)
            internal static void Colar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.V);
            }

            /// Recortar (CTRL + X)
            internal static void Recortar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.X);
            }

            /// Desfazer (CTRL + Z)
            internal static void Desfazer()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.Z);
            }

            /// Refazer (CTRL + Y)
            internal static void Refazer()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.Y);
            }

            /// Localizar (CTRL + F)
            internal static void Localizar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F);
            }

            /// Substituir (CTRL + H)
            internal static void Substituir()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.H);
            }

            /// Selecionar tudo (CTRL + A)
            internal static void SelecionarTudo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.A);
            }

            // ===============================
            // 🧭 NAVEGAÇÃO
            // ===============================

            /// Ir para início da linha (HOME)
            internal static void IrInicioLinha()
            {
                LanzarTecla(KeyN.HOME);
            }

            /// Ir para fim da linha (END)
            internal static void IrFimLinha()
            {
                LanzarTecla(KeyN.END);
            }

            /// Ir para início da planilha (CTRL + HOME)
            internal static void IrInicioPlanilha()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.HOME);
            }

            /// Ir para última célula (CTRL + END)
            internal static void IrUltimaCelula()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.END);
            }

            /// Próxima planilha (CTRL + PAGE DOWN)
            internal static void ProximaPlanilha()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.NEXT);
            }

            /// Planilha anterior (CTRL + PAGE UP)
            internal static void PlanilhaAnterior()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.PRIOR);
            }

            // ===============================
            // 📊 FÓRMULAS
            // ===============================

            /// Inserir AutoSoma (ALT + =)
            internal static void AutoSoma()
            {
                LanzarCombo(KeyN.MENU, KeyN.OEM_PLUS);
            }

            /// Editar célula (F2)
            internal static void EditarCelula()
            {
                LanzarTecla(KeyN.F2);
            }

            /// Inserir função (SHIFT + F3)
            internal static void InserirFuncao()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F3);
            }

            /// Calcular tudo (F9)
            internal static void Calcular()
            {
                LanzarTecla(KeyN.F9);
            }

            /// Calcular planilha ativa (SHIFT + F9)
            internal static void CalcularPlanilha()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F9);
            }

            // ===============================
            // 🎨 FORMATAÇÃO
            // ===============================

            /// Negrito (CTRL + B)
            internal static void Negrito()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.B);
            }

            /// Itálico (CTRL + I)
            internal static void Italico()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.I);
            }

            /// Sublinhado (CTRL + U)
            internal static void Sublinhado()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.U);
            }

            /// Formatar célula (CTRL + 1)
            internal static void FormatarCelula()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.NUM_1);
            }

            // ===============================
            // 📏 LINHAS E COLUNAS
            // ===============================

            /// Inserir linha (CTRL + SHIFT + +)
            internal static void InserirLinha()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.OEM_PLUS);
            }

            /// Excluir linha (CTRL + -)
            internal static void ExcluirLinha()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.OEM_MINUS);
            }

            /// Ocultar linha (CTRL + 9)
            internal static void OcultarLinha()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.NUM_9);
            }

            /// Ocultar coluna (CTRL + 0)
            internal static void OcultarColuna()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.NUM_0);
            }

            // ===============================
            // 📄 PLANILHAS
            // ===============================

            /// Nova planilha (SHIFT + F11)
            internal static void NovaPlanilha()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F11);
            }

            // ===============================
            // 🪟 JANELAS
            // ===============================

            /// Nova janela (CTRL + ALT + N)
            internal static void NovaJanela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.N);
            }

            /// Alternar janela (CTRL + TAB)
            internal static void AlternarJanela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.TAB);
            }

            /// Tela cheia (ALT + V, U)
            internal static void TelaCheia()
            {
                LanzarCombo(KeyN.MENU, KeyN.V);
                LanzarTecla(KeyN.U);
            }

            // ===============================
            // 🧑‍💻 VBA
            // ===============================

            /// Abrir editor VBA (ALT + F11)
            internal static void AbrirVBA()
            {
                LanzarCombo(KeyN.MENU, KeyN.F11);
            }

            /// Executar macro (ALT + F8)
            internal static void ExecutarMacro()
            {
                LanzarCombo(KeyN.MENU, KeyN.F8);
            }


            // ===============================
            // 🟦 SELEÇÃO AVANÇADA
            // ===============================

            /// Selecionar coluna inteira (CTRL + SPACE)
            internal static void SelecionarColuna()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SPACE);
            }

            /// Selecionar linha inteira (SHIFT + SPACE)
            internal static void SelecionarLinha()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.SPACE);
            }

            /// Selecionar região atual (CTRL + SHIFT + *)
            internal static void SelecionarRegiaoAtual()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.MULTIPLY);
            }

            /// Expandir seleção para cima (CTRL + SHIFT + UP)
            internal static void ExpandirSelecaoCima()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.UP);
            }

            /// Expandir seleção para baixo (CTRL + SHIFT + DOWN)
            internal static void ExpandirSelecaoBaixo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.DOWN);
            }

            /// Expandir seleção esquerda (CTRL + SHIFT + LEFT)
            internal static void ExpandirSelecaoEsquerda()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.LEFT);
            }

            /// Expandir seleção direita (CTRL + SHIFT + RIGHT)
            internal static void ExpandirSelecaoDireita()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.RIGHT);
            }

            /// Selecionar células visíveis apenas (ALT + ;)
            internal static void SelecionarVisiveis()
            {
                LanzarCombo(KeyN.MENU, KeyN.OEM_1);
            }

            // ===============================
            // ⚡ PREENCHIMENTO AUTOMÁTICO
            // ===============================

            /// Preencher para baixo (CTRL + D)
            internal static void PreencherBaixo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.D);
            }

            /// Preencher para direita (CTRL + R)
            internal static void PreencherDireita()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.R);
            }

            /// Copiar fórmula de cima (CTRL + ')
            internal static void CopiarFormulaCima()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.OEM_7);
            }

            /// Inserir data atual (CTRL + ;)
            internal static void InserirDataAtual()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.OEM_1);
            }

            /// Inserir hora atual (CTRL + SHIFT + ;)
            internal static void InserirHoraAtual()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.OEM_1);
            }

            // ===============================
            // 📊 TABELAS
            // ===============================

            /// Criar tabela (CTRL + T)
            internal static void CriarTabela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.T);
            }

            /// Expandir tabela (TAB)
            internal static void ExpandirTabela()
            {
                LanzarTecla(KeyN.TAB);
            }

            /// Selecionar linha tabela (SHIFT + SPACE)
            internal static void SelecionarLinhaTabela()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.SPACE);
            }

            /// Selecionar coluna tabela (CTRL + SPACE)
            internal static void SelecionarColunaTabela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SPACE);
            }

            // ===============================
            // 🔎 FILTROS
            // ===============================

            /// Ativar / desativar filtro (CTRL + SHIFT + L)
            internal static void AlternarFiltro()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.L);
            }

            /// Abrir menu filtro (ALT + DOWN)
            internal static void AbrirFiltro()
            {
                LanzarCombo(KeyN.MENU, KeyN.DOWN);
            }

            /// Reaplicar filtro (CTRL + ALT + L)
            internal static void ReaplicarFiltro()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.L);
            }

            /// Limpar filtro (ALT + D + F + F)
            internal static void LimparFiltro()
            {
                LanzarCombo(KeyN.MENU, KeyN.D);
                LanzarTecla(KeyN.F);
                LanzarTecla(KeyN.F);
            }

            // ===============================
            // 📈 GRÁFICOS
            // ===============================

            /// Criar gráfico (ALT + F1)
            internal static void CriarGrafico()
            {
                LanzarCombo(KeyN.MENU, KeyN.F1);
            }

            /// Criar gráfico nova folha (F11)
            internal static void CriarGraficoNovaFolha()
            {
                LanzarTecla(KeyN.F11);
            }

            /// Selecionar gráfico (CTRL + SHIFT + SPACE)
            internal static void SelecionarGrafico()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.SPACE);
            }

            // ===============================
            // 🧭 NAVEGAÇÃO AVANÇADA
            // ===============================

            /// Ir próxima célula (TAB)
            internal static void ProximaCelula()
            {
                LanzarTecla(KeyN.TAB);
            }

            /// Ir célula anterior (SHIFT + TAB)
            internal static void CelulaAnterior()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.TAB);
            }

            /// Ir próxima linha (ENTER)
            internal static void ProximaLinha()
            {
                LanzarTecla(KeyN.RETURN);
            }

            /// Ir linha anterior (SHIFT + ENTER)
            internal static void LinhaAnterior()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.RETURN);
            }

            /// Ir última linha dados (CTRL + DOWN)
            internal static void IrUltimaLinhaDados()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.DOWN);
            }

            /// Ir primeira linha dados (CTRL + UP)
            internal static void IrPrimeiraLinhaDados()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.UP);
            }

            /// Ir última coluna dados (CTRL + RIGHT)
            internal static void IrUltimaColunaDados()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.RIGHT);
            }

            /// Ir primeira coluna dados (CTRL + LEFT)
            internal static void IrPrimeiraColunaDados()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.LEFT);
            }


            // ===============================
            // 📊 PIVOT TABLE
            // ===============================

            /// Criar Pivot Table (ALT + N + V)
            internal static void CriarPivotTable()
            {
                LanzarCombo(KeyN.MENU, KeyN.N);
                LanzarTecla(KeyN.V);
            }

            /// Atualizar Pivot Table (ALT + F5)
            internal static void AtualizarPivot()
            {
                LanzarCombo(KeyN.MENU, KeyN.F5);
            }

            /// Atualizar tudo (CTRL + ALT + F5)
            internal static void AtualizarTudo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.F5);
            }


            // ===============================
            // 🧪 AUDITORIA DE FÓRMULAS
            // ===============================

            /// Mostrar fórmulas (CTRL + `)
            internal static void MostrarFormulas()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.OEM_3);
            }

            /// Avaliar fórmula (ALT + T + U + F)
            internal static void AvaliarFormula()
            {
                LanzarCombo(KeyN.MENU, KeyN.T);
                LanzarTecla(KeyN.U);
                LanzarTecla(KeyN.F);
            }

            /// Rastrear precedentes (CTRL + [)
            internal static void RastrearPrecedentes()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.OEM_4);
            }

            /// Rastrear dependentes (CTRL + ])
            internal static void RastrearDependentes()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.OEM_6);
            }


            // ===============================
            // 🏷️ NOMES DE INTERVALOS
            // ===============================

            /// Definir nome (CTRL + F3)
            internal static void DefinirNome()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F3);
            }

            /// Criar nome automático (CTRL + SHIFT + F3)
            internal static void CriarNomeAutomatico()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.F3);
            }

            /// Colar nome (F3)
            internal static void ColarNome()
            {
                LanzarTecla(KeyN.F3);
            }


            // ===============================
            // 📑 INSERÇÃO
            // ===============================

            /// Inserir células (CTRL + SHIFT + +)
            internal static void InserirCelulas()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.OEM_PLUS);
            }

            /// Excluir células (CTRL + -)
            internal static void ExcluirCelulas()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.OEM_MINUS);
            }

            /// Inserir comentário (SHIFT + F2)
            internal static void InserirComentario()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F2);
            }

            /// Editar comentário (SHIFT + F2)
            internal static void EditarComentario()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F2);
            }


            // ===============================
            // ⚡ POWER USER
            // ===============================

            /// Abrir menu contexto (SHIFT + F10)
            internal static void MenuContexto()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F10);
            }

            /// Repetir última ação (F4)
            internal static void RepetirUltimaAcao()
            {
                LanzarTecla(KeyN.F4);
            }

            /// Cancelar ação (ESC)
            internal static void Cancelar()
            {
                LanzarTecla(KeyN.ESCAPE);
            }

            /// Confirmar ação (ENTER)
            internal static void Confirmar()
            {
                LanzarTecla(KeyN.RETURN);
            }

            /// Alternar modo edição (F2)
            internal static void AlternarModoEdicao()
            {
                LanzarTecla(KeyN.F2);
            }


            // ===============================
            // 🪟 GERENCIAMENTO DE JANELAS
            // ===============================

            /// Minimizar janela (CTRL + F9)
            internal static void MinimizarJanela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F9);
            }

            /// Maximizar janela (CTRL + F10)
            internal static void MaximizarJanela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F10);
            }

            /// Restaurar janela (CTRL + F5)
            internal static void RestaurarJanela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F5);
            }

            /// Alternar janelas Excel (CTRL + F6)
            internal static void AlternarJanelaExcel()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F6);
            }


            // ===============================
            // 👨‍💻 VBA / DEVELOPER
            // ===============================

            /// Abrir VBA (ALT + F11)
            internal static void AbrirEditorVBA()
            {
                LanzarCombo(KeyN.MENU, KeyN.F11);
            }

            /// Criar macro (ALT + F8 depois digitar nome)
            internal static void CriarMacro()
            {
                LanzarCombo(KeyN.MENU, KeyN.F8);
            }

            /// Parar macro (CTRL + BREAK)
            internal static void PararMacro()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.CANCEL);
            }


            // ===============================
            // 📋 FORMATAÇÃO RÁPIDA
            // ===============================

            /// Formato moeda (CTRL + SHIFT + $)
            internal static void FormatoMoeda()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.NUM_4);
            }

            /// Formato porcentagem (CTRL + SHIFT + %)
            internal static void FormatoPorcentagem()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.NUM_5);
            }

            /// Formato científico (CTRL + SHIFT + ^)
            internal static void FormatoCientifico()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.NUM_6);
            }

            /// Formato data (CTRL + SHIFT + #)
            internal static void FormatoData()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.NUM_3);
            }

            /// Formato hora (CTRL + SHIFT + @)
            internal static void FormatoHora()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.NUM_2);
            }


            // ===============================
            // 🔄 RECÁLCULO
            // ===============================

            /// Calcular tudo (F9)
            internal static void CalcularTudo()
            {
                LanzarTecla(KeyN.F9);
            }

            /// Calcular planilha ativa (SHIFT + F9)
            internal static void CalcularPlanilhaAtiva()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F9);
            }

            /// Calcular forçado (CTRL + ALT + F9)
            internal static void CalcularForcado()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.F9);
            }

        }

        //  Exemplo de uso: Ax.WordShortcuts.Copiar();
        internal static class WordShortcuts
        {
            // ===============================
            // 📁 ARQUIVO
            // ===============================

            /// Novo documento (CTRL + N)
            internal static void NovoDocumento()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.N);
            }

            /// Abrir documento (CTRL + O)
            internal static void AbrirDocumento()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.O);
            }

            /// Salvar documento (CTRL + S)
            internal static void SalvarDocumento()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.S);
            }

            /// Salvar como (F12)
            internal static void SalvarComo()
            {
                LanzarTecla(KeyN.F12);
            }

            /// Imprimir (CTRL + P)
            internal static void Imprimir()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.P);
            }

            /// Fechar documento (CTRL + W)
            internal static void FecharDocumento()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.W);
            }

            // ===============================
            // ✏️ EDIÇÃO
            // ===============================

            /// Copiar (CTRL + C)
            internal static void Copiar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.C);
            }

            /// Colar (CTRL + V)
            internal static void Colar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.V);
            }

            /// Recortar (CTRL + X)
            internal static void Recortar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.X);
            }

            /// Desfazer (CTRL + Z)
            internal static void Desfazer()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.Z);
            }

            /// Refazer (CTRL + Y)
            internal static void Refazer()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.Y);
            }

            /// Selecionar tudo (CTRL + A)
            internal static void SelecionarTudo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.A);
            }

            // ===============================
            // 🔎 LOCALIZAÇÃO
            // ===============================

            /// Localizar (CTRL + F)
            internal static void Localizar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F);
            }

            /// Substituir (CTRL + H)
            internal static void Substituir()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.H);
            }

            /// Ir para (CTRL + G)
            internal static void IrPara()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.G);
            }

            // ===============================
            // 🎨 FORMATAÇÃO TEXTO
            // ===============================

            /// Negrito (CTRL + B)
            internal static void Negrito()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.B);
            }

            /// Itálico (CTRL + I)
            internal static void Italico()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.I);
            }

            /// Sublinhado (CTRL + U)
            internal static void Sublinhado()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.U);
            }

            /// Aumentar fonte (CTRL + SHIFT + >)
            internal static void AumentarFonte()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.OEM_PERIOD);
            }

            /// Diminuir fonte (CTRL + SHIFT + <)
            internal static void DiminuirFonte()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.OEM_COMMA);
            }

            /// Limpar formatação (CTRL + SPACE)
            internal static void LimparFormatacao()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SPACE);
            }

            // ===============================
            // 📄 PARÁGRAFO
            // ===============================

            /// Alinhar à esquerda (CTRL + L)
            internal static void AlinharEsquerda()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.L);
            }

            /// Alinhar centro (CTRL + E)
            internal static void AlinharCentro()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.E);
            }

            /// Alinhar direita (CTRL + R)
            internal static void AlinharDireita()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.R);
            }

            /// Justificar (CTRL + J)
            internal static void Justificar()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.J);
            }

            /// Novo parágrafo (ENTER)
            internal static void NovoParagrafo()
            {
                LanzarTecla(KeyN.RETURN);
            }

            // ===============================
            // 📋 ÁREA DE TRANSFERÊNCIA
            // ===============================

            /// Colar especial (CTRL + ALT + V)
            internal static void ColarEspecial()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.V);
            }

            // ===============================
            // 🧭 NAVEGAÇÃO
            // ===============================

            /// Início do documento (CTRL + HOME)
            internal static void InicioDocumento()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.HOME);
            }

            /// Fim do documento (CTRL + END)
            internal static void FimDocumento()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.END);
            }

            /// Próxima palavra (CTRL + RIGHT)
            internal static void ProximaPalavra()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.RIGHT);
            }

            /// Palavra anterior (CTRL + LEFT)
            internal static void PalavraAnterior()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.LEFT);
            }

            /// Próxima linha (DOWN)
            internal static void ProximaLinha()
            {
                LanzarTecla(KeyN.DOWN);
            }

            /// Linha anterior (UP)
            internal static void LinhaAnterior()
            {
                LanzarTecla(KeyN.UP);
            }

            // ===============================
            // 🪟 JANELA
            // ===============================

            /// Nova janela (CTRL + ALT + N)
            internal static void NovaJanela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.N);
            }

            /// Alternar janela (ALT + TAB)
            internal static void AlternarJanela()
            {
                LanzarCombo(KeyN.MENU, KeyN.TAB);
            }

            // ===============================
            // 🟦 SELEÇÃO AVANÇADA
            // ===============================

            /// Selecionar caractere à direita (SHIFT + RIGHT)
            internal static void SelecionarDireita()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.RIGHT);
            }

            /// Selecionar caractere à esquerda (SHIFT + LEFT)
            internal static void SelecionarEsquerda()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.LEFT);
            }

            /// Selecionar palavra à direita (CTRL + SHIFT + RIGHT)
            internal static void SelecionarPalavraDireita()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.RIGHT);
            }

            /// Selecionar palavra à esquerda (CTRL + SHIFT + LEFT)
            internal static void SelecionarPalavraEsquerda()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.LEFT);
            }

            /// Selecionar até início da linha (SHIFT + HOME)
            internal static void SelecionarInicioLinha()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.HOME);
            }

            /// Selecionar até fim da linha (SHIFT + END)
            internal static void SelecionarFimLinha()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.END);
            }

            /// Selecionar até início documento (CTRL + SHIFT + HOME)
            internal static void SelecionarInicioDocumento()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.HOME);
            }

            /// Selecionar até fim documento (CTRL + SHIFT + END)
            internal static void SelecionarFimDocumento()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.END);
            }

            // ===============================
            // 🎨 ESTILOS E TÍTULOS
            // ===============================

            /// Aplicar estilo Normal (CTRL + SHIFT + N)
            internal static void EstiloNormal()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.N);
            }

            /// Aplicar Título 1 (CTRL + ALT + 1)
            internal static void Titulo1()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.NUM_1);
            }

            /// Aplicar Título 2 (CTRL + ALT + 2)
            internal static void Titulo2()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.NUM_2);
            }

            /// Aplicar Título 3 (CTRL + ALT + 3)
            internal static void Titulo3()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.NUM_3);
            }

            /// Painel estilos (CTRL + SHIFT + ALT + S)
            internal static void PainelEstilos()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.MENU, KeyN.S);
            }

            // ===============================
            // 📋 LISTAS
            // ===============================

            /// Lista com marcadores (CTRL + SHIFT + L)
            internal static void ListaMarcadores()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.L);
            }

            /// Aumentar recuo (CTRL + M)
            internal static void AumentarRecuo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.M);
            }

            /// Diminuir recuo (CTRL + SHIFT + M)
            internal static void DiminuirRecuo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.M);
            }

            // ===============================
            // 📄 INSERÇÃO
            // ===============================

            /// Inserir quebra de página (CTRL + ENTER)
            internal static void QuebraPagina()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.RETURN);
            }

            /// Inserir quebra de linha (SHIFT + ENTER)
            internal static void QuebraLinha()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.RETURN);
            }

            /// Inserir hiperlink (CTRL + K)
            internal static void InserirHyperlink()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.K);
            }

            /// Inserir comentário (CTRL + ALT + M)
            internal static void InserirComentario()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.M);
            }

            /// Inserir data (ALT + SHIFT + D)
            internal static void InserirData()
            {
                LanzarCombo(KeyN.MENU, KeyN.SHIFT, KeyN.D);
            }

            /// Inserir hora (ALT + SHIFT + T)
            internal static void InserirHora()
            {
                LanzarCombo(KeyN.MENU, KeyN.SHIFT, KeyN.T);
            }

            // ===============================
            // 📊 TABELAS
            // ===============================

            /// Próxima célula (TAB)
            internal static void ProximaCelulaTabela()
            {
                LanzarTecla(KeyN.TAB);
            }

            /// Célula anterior (SHIFT + TAB)
            internal static void CelulaAnteriorTabela()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.TAB);
            }

            /// Nova linha na tabela (TAB última célula)
            internal static void NovaLinhaTabela()
            {
                LanzarTecla(KeyN.TAB);
            }

            // ===============================
            // 📑 QUEBRAS E PAGINAÇÃO
            // ===============================

            /// Quebra seção próxima página (CTRL + ALT + ENTER)
            internal static void QuebraSecao()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.RETURN);
            }

            // ===============================
            // 🧭 NAVEGAÇÃO PROFISSIONAL
            // ===============================

            /// Próxima página (CTRL + PAGE DOWN)
            internal static void ProximaPagina()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.NEXT);
            }

            /// Página anterior (CTRL + PAGE UP)
            internal static void PaginaAnterior()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.PRIOR);
            }

            /// Abrir painel navegação (CTRL + F)
            internal static void PainelNavegacao()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F);
            }

            /// Alternar modo leitura (ALT + W + F)
            internal static void ModoLeitura()
            {
                LanzarCombo(KeyN.MENU, KeyN.W);
                LanzarTecla(KeyN.F);
            }

            // ===============================
            // 📝 REVIEW / REVISÃO
            // ===============================

            /// Ativar/desativar controle alterações (CTRL + SHIFT + E)
            internal static void AlternarControlarAlteracoes()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.E);
            }

            /// Próximo comentário (CTRL + ALT + PAGE DOWN)
            internal static void ProximoComentario()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.NEXT);
            }

            /// Comentário anterior (CTRL + ALT + PAGE UP)
            internal static void ComentarioAnterior()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.PRIOR);
            }

            /// Inserir comentário (CTRL + ALT + M)
            internal static void NovoComentario()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.MENU, KeyN.M);
            }

            // ===============================
            // 🔎 PROOFING
            // ===============================

            /// Verificar ortografia (F7)
            internal static void VerificarOrtografia()
            {
                LanzarTecla(KeyN.F7);
            }

            /// Sinônimos (SHIFT + F7)
            internal static void Sinonimos()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F7);
            }

            /// Traduzir (ALT + SHIFT + F7)
            internal static void Traduzir()
            {
                LanzarCombo(KeyN.MENU, KeyN.SHIFT, KeyN.F7);
            }

            // ===============================
            // 🏷️ CAMPOS
            // ===============================

            /// Inserir campo (CTRL + F9)
            internal static void InserirCampo()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F9);
            }

            /// Atualizar campo (F9)
            internal static void AtualizarCampo()
            {
                LanzarTecla(KeyN.F9);
            }

            /// Alternar código campo (SHIFT + F9)
            internal static void AlternarCodigoCampo()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F9);
            }

            /// Atualizar todos campos (CTRL + A, F9)
            internal static void AtualizarTodosCampos()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.A);
                LanzarTecla(KeyN.F9);
            }

            // ===============================
            // 👨‍💻 MACROS / DEVELOPER
            // ===============================

            /// Abrir editor VBA (ALT + F11)
            internal static void AbrirVBA()
            {
                LanzarCombo(KeyN.MENU, KeyN.F11);
            }

            /// Executar macro (ALT + F8)
            internal static void ExecutarMacro()
            {
                LanzarCombo(KeyN.MENU, KeyN.F8);
            }

            /// Gravar macro (ALT + T, M, R)
            internal static void GravarMacro()
            {
                LanzarCombo(KeyN.MENU, KeyN.T);
                LanzarTecla(KeyN.M);
                LanzarTecla(KeyN.R);
            }

            /// Parar macro (CTRL + BREAK)
            internal static void PararMacro()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.CANCEL);
            }

            // ===============================
            // 🔒 PROTEÇÃO
            // ===============================

            /// Proteger documento (ALT + R, P, S)
            internal static void ProtegerDocumento()
            {
                LanzarCombo(KeyN.MENU, KeyN.R);
                LanzarTecla(KeyN.P);
                LanzarTecla(KeyN.S);
            }

            // ===============================
            // 🪟 GERENCIAMENTO JANELAS
            // ===============================

            /// Alternar janelas Word (CTRL + F6)
            internal static void AlternarJanelaWord()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F6);
            }

            /// Fechar janela (CTRL + W)
            internal static void FecharJanela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.W);
            }

            /// Restaurar janela (CTRL + F5)
            internal static void RestaurarJanela()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.F5);
            }

            // ===============================
            // ⚡ POWER USER
            // ===============================

            /// Mostrar/ocultar caracteres invisíveis (CTRL + SHIFT + 8)
            internal static void MostrarCaracteres()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.NUM_8);
            }

            /// Selecionar bloco vertical (CTRL + SHIFT + F8)
            internal static void SelecionarBlocoVertical()
            {
                LanzarCombo(KeyN.CONTROL, KeyN.SHIFT, KeyN.F8);
            }

            /// Cancelar seleção (ESC)
            internal static void Cancelar()
            {
                LanzarTecla(KeyN.ESCAPE);
            }

            /// Repetir última ação (F4)
            internal static void RepetirAcao()
            {
                LanzarTecla(KeyN.F4);
            }

            /// Abrir menu contexto (SHIFT + F10)
            internal static void MenuContexto()
            {
                LanzarCombo(KeyN.SHIFT, KeyN.F10);
            }

            // ===============================
            // 📑 OUTLINE MODE
            // ===============================

            /// Modo estrutura (ALT + CTRL + O)
            internal static void ModoEstrutura()
            {
                LanzarCombo(KeyN.MENU, KeyN.CONTROL, KeyN.O);
            }

            /// Promover título (ALT + SHIFT + LEFT)
            internal static void PromoverTitulo()
            {
                LanzarCombo(KeyN.MENU, KeyN.SHIFT, KeyN.LEFT);
            }

            /// Rebaixar título (ALT + SHIFT + RIGHT)
            internal static void RebaixarTitulo()
            {
                LanzarCombo(KeyN.MENU, KeyN.SHIFT, KeyN.RIGHT);
            }
        }
    }
}
