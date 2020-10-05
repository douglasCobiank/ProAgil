import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})

export class EventosComponent implements OnInit {

  _filtroLista: string;
  get filtroLista(): string{
    return this._filtroLista;
  }
  set filtroLista(values: string){
    this._filtroLista = values;
    this.eventosFiltrados = this.filtroLista ? this.filtrarEvento(this.filtroLista) : this.eventos;
  }

  eventosFiltrados: any = [];
  eventos: any = [];
  imagemLargura = 50;
  imagemAltura = 50;
  mostrarImagem = false;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }

  filtrarEvento(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      evento => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }
  alterarImagem(){
    this.mostrarImagem = !this.mostrarImagem;
  }

  getEventos(){
    this.eventos = this.http.get('http://localhost:5000/api/values').subscribe(response =>
    {this.eventos = response;
    }, error => {
      console.log(error);
    });
  }
}
