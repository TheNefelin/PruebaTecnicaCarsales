import { Component, OnInit, signal } from '@angular/core';
import { EpisodeService } from '../../services/episode.service';
import { Episode } from '../../models/episode.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-episode-table',
  imports: [],
  templateUrl: './episode-table.html',
  styleUrl: './episode-table.css',
})
export class EpisodeTable implements OnInit {

  episodes = signal<Episode[]>([]);
  currentPage = signal(1);
  totalPages = signal(1);
  filterName = signal('');

  constructor(
    private router: Router,
    private episodeService: EpisodeService
  ) {}

  ngOnInit() {
    this.loadEpisodes(1);
  }

  loadEpisodes(page: number) {
    this.episodeService
      .getEpisodes(page, this.filterName())
      .subscribe({
        next: data => {
          this.episodes.set(data.results);
          this.currentPage.set(data.page);
          this.totalPages.set(data.totalPages);
        },
        error: err => console.error('Error fetching episodes', err)
      });
  }

  onFilterChange(value: string) {
    this.filterName.set(value);
    this.loadEpisodes(1);
  }

  nextPage() {
    if (this.currentPage() < this.totalPages()) {
      this.loadEpisodes(this.currentPage() + 1);
    }
  }

  prevPage() {
    if (this.currentPage() > 1) {
      this.loadEpisodes(this.currentPage() - 1);
    }
  }
}