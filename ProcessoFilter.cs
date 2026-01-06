using AGP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGP
{

    /// <summary>
    /// Classe responsável por aplicar filtros cumulativos
    /// sobre a entidade Processo.
    /// </summary>
    public class ProcessoFilter
    {
     /// <summary>
     /// Aplica filtros dinâmicos à consulta de Processos
     /// com base nos parâmetros informados.
     /// Apenas os filtros diferentes de null são aplicados.
     /// </summary>
     /// <param name="query">
     /// Consulta base (IQueryable) sobre a entidade Processo.
     /// Normalmente vem de db.Processos.
     /// </param>
     /// <param name="categoria">Categoria selecionada no ComboBox</param>
     /// <param name="estado">Estado selecionado no ComboBox</param>
     /// <param name="prioridade">Prioridade selecionada no ComboBox</param>
     /// <param name="funcionario">Funcionário selecionado no ComboBox</param>
     /// <param name="cliente">Cliente selecionado no ComboBox</param>
     /// <returns>
     /// IQueryable contendo todos os filtros aplicados de forma cumulativa
     /// </returns>
        public IQueryable<Processo> FiltrarProcessos(
            IQueryable<Processo> query,
            Categoria categoria,
            Estado estado,
            Prioridade prioridade,
            Funcionario funcionario,
            Cliente cliente, 
            Categoria lstCategoria,
            Estado lstEstado,
            Prioridade lstPrioridade)

        {

            // ------------- LIST BOX FILTROS ------------- 

            // Aplica filtro por Categoria, caso exista
            if (lstCategoria != null)
            {
                if (lstCategoria.Id == 0) // "Todas" categorias
                {
                    query = query.Where(p => p.CategoriaId != 0); // Mantém todos os processos (nenhum filtro aplicado)
                }
                else
                {
                    query = query.Where(p => p.CategoriaId == lstCategoria.Id); // Filtra pela categoria selecionada
                }
            }

            // Aplica filtro por Estado, caso exista
            if (lstEstado != null)
            {
                if (lstEstado.Id == 0) // "Todos" estados
                {
                    query = query.Where(p => p.EstadoId != 0); // Mantém todos os processos (nenhum filtro aplicado)
                }
                else
                { 
                    query = query.Where(p => p.EstadoId == lstEstado.Id); // Filtra pelo estado selecionado
                }
            }

            // Aplica filtro por Prioridade, caso exista
            if (lstPrioridade != null)
            {
                if (lstPrioridade.Id == 0) // "Todas" prioridades
                {
                    query = query.Where(p => p.PrioridadeId != 0); // Mantém todos os processos (nenhum filtro aplicado)
                }
                else
                { 
                    query = query.Where(p => p.PrioridadeId == lstPrioridade.Id); // Filtra pela prioridade selecionada
                }
            }

            // ------------- COMBO BOX FILTROS ------------- 

            // Aplica filtro por Categoria, caso exista
            if (categoria != null) // Evita filtro desnecessário quando "Todas" categorias é selecionada
            {
                if (categoria.Id == 0) // "Todas" categorias
                {
                    query = query.Where(p => p.CategoriaId != 0); // Mantém todos os processos (nenhum filtro aplicado)
                }
                else
                {
                    query = query.Where(p => p.CategoriaId == categoria.Id); // Filtra pela categoria selecionada
                }
            }

            // Aplica filtro por Estado, caso exista
            if (estado != null)
            {
                if (estado.Id == 0) // "Todos" estados
                {
                    query = query.Where(p => p.EstadoId != 0); // Mantém todos os processos (nenhum filtro aplicado)
                }
                else
                {
                    query = query.Where(p => p.EstadoId == estado.Id); // Filtra pelo estado selecionado
                }
            }

            // Aplica filtro por Prioridade, caso exista
            if (prioridade != null)
            {
                if (prioridade.Id == 0) // "Todas" prioridades
                {
                    query = query.Where(p => p.PrioridadeId != 0); // Mantém todos os processos (nenhum filtro aplicado)
                }
                else
                {
                    query = query.Where(p => p.PrioridadeId == prioridade.Id); // Filtra pela prioridade selecionada
                }
            }

            // Aplica filtro por Funcionário, caso exista
            if (funcionario != null)
            {
                if (funcionario.Id == 0) // "Todos" funcionários
                {
                    query = query.Where(p => p.FuncionarioId != 0); // Mantém todos os processos (nenhum filtro aplicado)
                }
                else
                {
                    query = query.Where(p => p.FuncionarioId == funcionario.Id); // Filtra pelo funcionário selecionado
                }
            }
            // Aplica filtro por Cliente, caso exista
            if (cliente != null)
            {   
                if (cliente.Id == 0) // "Todos" clientes
                {
                    query = query.Where(p => p.ClienteId != 0); // Mantém todos os processos (nenhum filtro aplicado)
                }
                else
                {
                    query = query.Where(p => p.ClienteId == cliente.Id); // Filtra pelo cliente selecionado
                }
            }

            // Retorna a query com todos os filtros aplicados
            return query;
        }
    }
}

