import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeadHeadComponent } from './head-head.component';

describe('HeadHeadComponent', () => {
  let component: HeadHeadComponent;
  let fixture: ComponentFixture<HeadHeadComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HeadHeadComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HeadHeadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
