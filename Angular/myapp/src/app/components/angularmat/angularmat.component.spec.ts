import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AngularmatComponent } from './angularmat.component';

describe('AngularmatComponent', () => {
  let component: AngularmatComponent;
  let fixture: ComponentFixture<AngularmatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AngularmatComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AngularmatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
