import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { PagedResult } from "../models/paged-result.model";
import { Episode } from "../models/episode.model";
import { environment } from "../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class EpisodeService {
  private baseUrl = `${environment.apiBaseUrl}/Episode`;

  constructor(private http: HttpClient) {}

  getEpisodes(page: number = 1, name?: string): Observable<PagedResult<Episode>> {
    const params: any = { page };

    if (name && name.trim().length > 0) {
      params.name = name;
    }

    return this.http.get<PagedResult<Episode>>(
      this.baseUrl,
      { params }
    );
  }
}