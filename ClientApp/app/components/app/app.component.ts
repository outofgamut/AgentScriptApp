import { Component } from '@angular/core';
import { CampaignService } from './campaign.service';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    providers: [CampaignService]
})
export class AppComponent {
}
