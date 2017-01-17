import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { DialogueComponent } from './components/dialogue/dialogue.component';
import { CampaignListComponent } from './components/app/campaign-list.component';
import { CampaignService } from './components/app/campaign.service';

@NgModule({
    bootstrap: [ AppComponent ],
    providers: [CampaignService],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        DialogueComponent,
        FetchDataComponent,
        CampaignListComponent,
        HomeComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'dialogue', component: DialogueComponent },
            { path: 'fetch-data', component: CampaignListComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModule {
}
