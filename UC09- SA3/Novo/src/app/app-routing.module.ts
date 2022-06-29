import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './views/cadastro/cadastro.component';
import { ComputadorComponent } from './views/computador/computador.component';
import { HomeComponent } from './views/home/home.component';

const routes: Routes = [
  {path:"", component: HomeComponent},
  {path: "cadastro", component: CadastroComponent},
  {path: "computador", component: ComputadorComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
