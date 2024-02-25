import { Component, OnInit, TemplateRef } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { AuthenticationService } from '../auth/services/authentication.service';
import { Departamento } from '../departamentos/models/departamento.model';
import { DepartamentoService } from '../departamentos/services/departamento.service';
import { Funcionario } from './models/funcionario.model';
import { FuncionarioService } from './services/funcionario.service';

@Component({
  selector: 'app-funcionario',
  templateUrl: './funcionario.component.html'
})
export class FuncionarioComponent implements OnInit {
  public funcionario$: Observable<Funcionario[]>;
  public departamentos$: Observable<Departamento[]>;
  public form: FormGroup;

  constructor(
    titulo: Title,
    private router: Router,
    private authService: AuthenticationService,
    private funcionarioService: FuncionarioService,
    private departamentoService: DepartamentoService,
    private toastrService: ToastrService,
    private modalService: NgbModal,
    private fb: FormBuilder
    ) {
     titulo.setTitle('Funcionários - RequisiçõesApp') ;
     }

  ngOnInit(): void {
    this.form = this.fb.group({
      funcionario: new FormGroup({
        id: new FormControl(""),
        nome: new FormControl("", [Validators.required, Validators.minLength(3)]),
        email: new FormControl("", [Validators.required, Validators.email]),
        funcao: new FormControl("", [Validators.required, Validators.minLength(3)]),
        departamentoId: new FormControl("", [Validators.required]),
        departamento: new FormControl(""),
      }),
      senha: new FormControl("")
    });

    this.funcionario$ = this.funcionarioService.selecionarTodos();
    this.departamentos$ = this.departamentoService.selecionarTodos();
  }

  get tituloModal(): string{
    return this.id?.value ? "Atualizar" : "Cadastro";
  }

  get id(): AbstractControl | null{
    return this.form.get("funcionario.id");
  }

  get nome(): AbstractControl | null{
    return this.form.get("funcionario.nome");
  }

  get email(): AbstractControl | null{
    return this.form.get("funcionario.email");
  }

  get funcao(): AbstractControl | null{
    return this.form.get("funcionario.funcao");
  }

  get departamentoId(): AbstractControl | null{
    return this.form.get("funcionario.departamentoId");
  }

  get senha(): AbstractControl | null{
    return this.form.get("senha");
  }

  public async gravar(modal: TemplateRef<any>, funcionario?: Funcionario){
    this.form.reset();

    if(funcionario){
      const departamento = funcionario.departamento ? funcionario.departamento : null;

      // spread operator (javascript)
      const funcionarioCompleto = {
        ...funcionario,
        departamento
      }

      this.form.get("funcionario")?.setValue(funcionarioCompleto);
    }


    try{
      await this.modalService.open(modal).result;

      if(this.form.dirty && this.form.valid){
        if(!funcionario){
          await this.authService.cadastrar(this.email?.value, this.senha?.value);

          await this.funcionarioService.inserir(this.form.get("funcionario")?.value);

          await this.authService.logout();

          await this.router.navigate(["/login"]);
        }
      else
        await this.funcionarioService.editar(this.form.get("funcionario")?.value);

          this.toastrService.success('O funcionário foi salvo com sucesso!', "Cadastro de Funcionários");
      }
      else
        this.toastrService.error("O formulário precisa ser preenchido!", "Cadastro de Funcionários");

    }catch(error){
      if(error != "fechar" && error != "0" && error != "1")
      this.toastrService.error("Houve um erro ao salvar o funcionário. Tente Novamente.", "Cadastro de Funcionarios");
    }
  }

  public async excluir(funcionario: Funcionario){
    try{
      await this.funcionarioService.excluir(funcionario);

      this.toastrService.success('O funcionário foi excluído com sucesso!', "Cadastro de Funcionarios");
    }catch(error){
      console.log(error);
    }

  }

}
