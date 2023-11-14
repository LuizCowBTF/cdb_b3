import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  valor!: number;
  prazo!: number;
  resultadoBruto: number = 0;
  resultadoLiquido: number = 0;

  calcularInvestimento() {
    // Lógica de cálculo do investimento (exemplo simples)
    const taxaJuros = 0.05; // 5%
    this.resultadoBruto = this.valor * Math.pow(1 + taxaJuros, this.prazo);
    this.resultadoLiquido = this.resultadoBruto - this.valor;
  }
}

