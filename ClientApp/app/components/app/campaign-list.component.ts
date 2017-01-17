import { Component } from '@angular/core';
import { OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Campaign } from './campaign';
import { CampaignService } from './campaign.service';

@Component({
    selector: 'campaign-list',
    providers: [CampaignService],
    templateUrl: './campaign-list.component.html'
})
export class CampaignListComponent implements OnInit {
    public campaigns: Campaign[];
    newCampaign: Campaign = new Campaign();

    constructor(private campaignService: CampaignService) {

    }

    ngOnInit(): void {
        this.campaignService.getCampaigns().then(heroes => this.campaigns = heroes);
    }

    deleteCampaign(id: string): void {
        this.campaignService.removeCampaign(id);
    }

    addCampaign(): void {
        this.campaignService.addCampaign(this.newCampaign).then(campaign => {
            this.campaigns.push(campaign);
        });
        this.newCampaign = new Campaign();
    }
}
