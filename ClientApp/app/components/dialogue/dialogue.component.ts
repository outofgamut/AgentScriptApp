import { Component } from '@angular/core';

@Component({
    selector: 'dialogue',
    templateUrl: './dialogue.component.html'
})
export class DialogueComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
