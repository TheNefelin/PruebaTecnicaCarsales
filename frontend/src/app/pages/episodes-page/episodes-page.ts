import { Component } from '@angular/core';
import { EpisodeTable } from '../../components/episode-table/episode-table';

@Component({
  selector: 'app-episodes-page',
  imports: [
    EpisodeTable
  ],
  templateUrl: './episodes-page.html',
  styleUrl: './episodes-page.css',
})
export class EpisodesPage {

}
