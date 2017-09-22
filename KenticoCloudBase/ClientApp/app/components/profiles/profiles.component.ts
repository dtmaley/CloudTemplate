import { Component, OnInit } from '@angular/core';

import { ToasterService } from "angular2-toaster";
import { ProfileService } from "../../services/profile.service";

import { Profile } from "../../classes/profile";


@Component({
    selector: 'profiles',
    templateUrl: './profiles.component.html',
    styleUrls: ['../../scss/master.scss']
})

export class ProfilesComponent implements OnInit {

    profiles: Profile[];

    constructor(private profileService: ProfileService, private toasterService: ToasterService) { };

    ngOnInit() {
        // Get all profiles
        this.profileService.getProfiles().then(associateProfiles => this.profiles = associateProfiles);
    }
}
