﻿using ControleMedicamentos.Dominio.ModuloFornecedor;
using ControleMedicamentos.Infra.BancoDados.Compartilhado;

namespace ControleMedicamentos.Infra.BancoDados.ModuloFornecedor
{
    public class RepositorioFornecedorEmBancoDados :
        RepositorioBase<Fornecedor, ValidadorFornecedor, MapeadorFornecedor>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBFORNECEDOR]
                (
                    [NOME],       
                    [TELEFONE], 
                    [EMAIL],
                    [CIDADE],                    
                    [ESTADO]   
                )
            VALUES
                (
                    @NOME,
                    @TELEFONE,
                    @EMAIL,
                    @CIDADE,
                    @ESTADO
                ); SELECT SCOPE_IDENTITY();";        

        protected override string sqlEditar =>
            @" UPDATE [TBFORNECEDOR]
                    SET 
                        [NOME] = @NOME, 
                        [TELEFONE] = @TELEFONE, 
                        [EMAIL] = @EMAIL,
                        [CIDADE] = @CIDADE, 
                        [ESTADO] = @ESTADO
                    WHERE [ID] = @ID";
        
        protected override string sqlExcluir =>
            @"DELETE FROM [TBMEDICAMENTO]
                WHERE [FORNECEDOR_ID] = @ID
                DELETE FROM [TBFORNECEDOR] 
                    WHERE [ID] = @ID";        

        protected override string sqlSelecionarTodos =>
            @"SELECT 
                [ID],       
                [NOME],
                [TELEFONE],
                [EMAIL],             
                [CIDADE],                    
                [ESTADO]
            FROM
                [TBFORNECEDOR]";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
                [ID],       
                [NOME],
                [TELEFONE],
                [EMAIL],             
                [CIDADE],                    
                [ESTADO]
            FROM
                [TBFORNECEDOR]
            WHERE 
                [ID] = @ID";
    }
}
