import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DatabindingComponent } from './components/databinding/databinding.component';
import { DirectiveComponent } from './components/directive/directive.component';
import { FormsModule } from '@angular/forms';
import { MypipeComponent } from './components/mypipe/mypipe.component';
import { CubePipe } from './Shared/custompipe/cube.pipe';
import { SquarePipe } from './Shared/custompipe/square.pipe';
import { AreaPipe } from './Shared/custompipe/area.pipe';
import { EmpDetailsComponent } from './components/emp-details/emp-details.component';

@NgModule({
  declarations: [
    AppComponent,
    DatabindingComponent,
    DirectiveComponent,
    MypipeComponent,
    CubePipe,
    SquarePipe,
    AreaPipe,
    EmpDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
