import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EpisodeTable } from './episode-table';

describe('EpisodeTable', () => {
  let component: EpisodeTable;
  let fixture: ComponentFixture<EpisodeTable>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EpisodeTable]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EpisodeTable);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
