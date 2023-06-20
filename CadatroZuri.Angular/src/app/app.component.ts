import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'CadatroZuri.Angular';
  form: FormGroup;
  constructor(private fb: FormBuilder, private http: HttpClient) {
    this.form = fb.group({
      nome: ['', Validators.required],
      dtNascimento: ['', Validators.required],
      email: ['', [Validators.required]],
      estadoCivil: ['', Validators.required],
    });
  }

  onSubmit() {
    const payload = {
      nome: this.form.controls['nome'].value,
      dataNascimento: this.form.controls['dtNascimento'].value,

      email: this.form.controls['email'].value,
      estadoCivil: +this.form.controls['estadoCivil'].value,
    }
    console.log(payload);

    if (!this.form.valid) return;
    

    this.http.post<any>('https://localhost:7142/Cliente', payload ).subscribe(
      result => {
        alert('Salvo com sucesso!')
      }, error => alert('Erro: ' + error));


  }
}
